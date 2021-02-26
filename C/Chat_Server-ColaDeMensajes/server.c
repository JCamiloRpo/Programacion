#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/msg.h>
#include <pthread.h>

#define PERMS 0666
#define SIZE 300
#define MAX 40

struct msgbuf { /*Formato del mensaje*/
  long mtype;
  char mtext[SIZE];
};

struct Client{
  long id;
  char name[20];
};

int msqid;
struct Client clients[MAX];/*Cada posicion guarda el PID de cada proceso para esta recibiendo sus mensajes con ese identificador*/
struct msgbuf buf[2]; /*Posicion 0 para enviar, posicion 1 para recibir, asi se evita la sobreescritura*/

int add(char* name, long pd){/*Metodo para obtener un posicion si hay alguna libre*/
  for(int i=0; i<MAX; i++){
    if(clients[i].id ==-1){
      clients[i].id = pd;
      sprintf(clients[i].name, "%s", name);
      return i;
    }
  }
  return -1;
}

int find(long pd){/*Metodod para hallar la posicion de un cliente*/
  for(int i=0; i<MAX; i++)
    if(clients[i].id==pd) return i;
  return -1;
}

void enviarMsg(int pos, int all){/*Codigo para el mensaje de un cliente al resto, llamado por un hilo*/
  int len;
	sprintf(buf[0].mtext, "%s",buf[1].mtext);/*Replico el mensaje*/
  printf("LOG: %s\n",buf[0].mtext);/*Impresion de log*/
  if(all){
    for(int i=0; i<MAX; i++){
      if(i != pos && clients[i].id != -1){/*Envio a todos excepto al que llamo la funcion y a los que no tengo identificados (-1)*/
        buf[0].mtype = clients[i].id; /*Corresponde al PID del que recibe*/
        len = strlen(buf[0].mtext);
        if (msgsnd(msqid, &buf[0], len+1, 0) == -1)/*Enviar el mensaje a la cola*/
          perror("msgsnd all: ");
      }
    }
    return;
  }
  buf[0].mtype = pos; /*Si no es para todos es enviar solo al del identificador que me manda como pos*/
  sprintf(buf[0].mtext, "%s",buf[1].mtext);/*Replico el mensaje*/
  len = strlen(buf[0].mtext);
  if (msgsnd(msqid, &buf[0], len+1, 0) == -1)/*Enviar el mensaje a la cola*/
    perror("msgsnd one: ");
}

void* recibirMsg(void *args){/*Codigo para recibir mensajes, ejecutado por el un hilo */
  int pos = -1;
  long pd=-1;
  char name[20], command[SIZE],arg[SIZE];/*Variables auxliares para organizar el mensaje que llega*/
  while(1){
    if (msgrcv(msqid, &buf[1], SIZE, 5, 0) == -1) {
      perror("msgrcv: ");
      exit(EXIT_FAILURE);
    }
    sscanf(buf[1].mtext, "%s %s %[^\n]", name, command, arg);
    
    if(strcasecmp(buf[1].mtext,"shutdown")==0){/*Si se cierra el chat, notifico a todos*/
      sprintf(buf[1].mtext,"Grupo cerrado");/*Asignar el mensaje a mostrar*/
      enviarMsg(MAX,1);/*Envio a todos que el chat esta cerrado*/
      break;
    }
    else if(strcasecmp(command,"connect")==0){/*Si me piden una conexion*/
      sscanf(arg, "%ld", &pd);/*Guardar la identificacion del proceso que escribió*/
      pos = add(name,pd);/*Guardo el usuario si hay espacio*/
      if(pos != -1){/*Si el grupo no esta lleno*/
        printf("LOG: Cliente %ld conectado en %d\n", clients[pos].id,pos);/*Mensaje de log*/
        sprintf(buf[1].mtext,"%s conectado", clients[pos].name);/*Asignar el mensaje a mostrar, para enviar a todos*/
        enviarMsg(pos,1);/*Enviar a todos*/
      }
      else{/*El grupo esta lleno*/
        printf("Grupo lleno\n");/*Mensaje de log*/
        sprintf(buf[1].mtext,"Grupo lleno");/*Asignar el mensaje a mostrar*/
        enviarMsg(pd,0);/*Enviar al que me hizo la petición*/
      }
    }
    else if(strcasecmp(command,"disconnect")==0 && strcasecmp(arg," ")==0){ /*Si recibo un "disconnect", el cliente se desconectó*/
      sscanf(name, "%ld", &pd);/*Guardar la identificacion del proceso que escribió*/
	    pos = find(pd);
      sprintf(buf[1].mtext,"%s desconectado", clients[pos].name);/*Asignar el mensaje a mostrar, para enviar a todos*/
      enviarMsg(pos,1);/*Enviar a todos*/
      clients[pos].id = -1;/*Borro el PID*/
      sprintf(clients[pos].name, " ");
      printf("LOG: Cliente %ld desconectado por %d\n", pd,pos);/*Mensaje de log*/
    }
    else{
      sscanf(name, "%ld", &pd);
      pos = find(pd);
      sprintf(buf[1].mtext,"%s: %s %s", clients[pos].name, command, arg);/*Asignar el mensaje a mostrar, para enviar a todos*/
      enviarMsg(pos,1);/*Enviar a los demas*/
    }
    sprintf(arg," ");
  }
  return NULL;
}

void* readConsola(){/*Monitoriar la consola para cuando se va a cerrar*/
  int len;
  while(1){
    if(fgets(buf[0].mtext, 50, stdin) != NULL){/*Leer la consola*/
      buf[0].mtext[strcspn(buf[0].mtext, "\n")] = '\0';
      if(strcasecmp(buf[0].mtext,"shutdown")==0){/*Si se cierra el chat, notifico a todos*/
        break;
      }
    }
  }
  buf[0].mtype=5;
  len = strlen(buf[0].mtext);
  if (msgsnd(msqid, &buf[0], len+1, 0) == -1)/*Enviar el mensaje a la cola que lee el otro hilo*/
    perror("msgsnd readConsola: ");
  return NULL;
}

void createCola(){/*Crear la cola de mensajes*/
  key_t key;
  system("touch msgq.txt");

  if ((key = ftok("msgq.txt", 'A')) == -1) { /*Crear clave unica*/
    perror("ftok: ");
    exit(EXIT_FAILURE);
  }
  
  if ((msqid = msgget(key, IPC_CREAT | PERMS )) == -1) { /*Crear cola de mensajes*/
    perror("msgget: ");
    exit(EXIT_FAILURE);
  }
}

void removeCola(){
  if (msgctl(msqid, IPC_RMID, NULL) == -1) { /*Eliminar cola*/
    perror("msgctl:");
    exit(EXIT_FAILURE);
  }

  system("rm msgq.txt");
}

int main(void) {
  pthread_t h[2];
  
  for(int i=0; i<MAX; i++)
    clients[i].id = -1;

  createCola();/*Iniciar y crear la cola*/
  
  printf("Grupo abierto.\nEscriba 'shutdown' para cerrar el grupo\n");
  
  pthread_create(&h[0], NULL, &readConsola,NULL);/*Hilo pendiente de la consola*/
  pthread_create(&h[1], NULL, &recibirMsg,NULL);/*Hilo pendiente de los mensajes*/

  pthread_join(h[0], NULL);
  pthread_join(h[1], NULL);

  removeCola();/*Eliminar la cola*/

  printf("Grupo eliminado.\n");
  
  return EXIT_SUCCESS;
}


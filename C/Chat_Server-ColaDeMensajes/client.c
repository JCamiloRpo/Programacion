#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/msg.h>
#include <pthread.h>
#include <unistd.h>

#define PERMS 0666
#define SIZE 200

struct msgbuf {
  long mtype;
  char mtext[SIZE];
};

int msqid;
long PID; /*Envio con PID cuando es un mensaje para todos. envio con 10 cuando pido conexion, para que el servidor me identifique*/
struct msgbuf buf[2]; /*Posicion 0 para enviar, posicion 1 para recibir, asi se evita la sobreescritura*/
char name[20];

void send(){
  char aux[SIZE+20];
  buf[0].mtext[strcspn(buf[0].mtext, "\n")] = '\0';
  sprintf(aux, "%s %s", name, buf[0].mtext);
  sprintf(buf[0].mtext, "%s", aux);
  int len = strlen(buf[0].mtext);
  if (msgsnd(msqid, &buf[0], len+1, 0) == -1) /*Enviar el mensaje a la cola*/
    perror("msgsnd: ");
}

void file(char* file){/*Codigo para enviar el contenido de un archivo*/
  FILE *Fin = fopen(file, "r"); /*Abrir archivo que se va a enviar*/
  if(Fin == NULL) {
    perror("File error: ");
    return;
  }
  
  while(1){
    if(fgets(buf[0].mtext,SIZE,Fin)==NULL){/*Si se abrió el archivo guardo las lineas en el buffer a enviar*/
      fclose(Fin);
      break;
    }
    send();
  }
}

void *enviarMsg(void* args){/*Codigo para leer la consola, ejecutado por un hilo*/
  char command[SIZE], arg[SIZE];
  buf[0].mtype = 5;
  printf("Digite 'connect [nombre]' para conectarse al chat grupal.\n");
  while(1) {
    
    if(fgets(buf[0].mtext, SIZE, stdin) != NULL){/*Obtener el mensaje por consola*/
	  if(strlen(buf[0].mtext)>0){
      if(strcasecmp(buf[1].mtext,"Grupo cerrado")==0) /*Recibí un "Grupo cerrado", se terminó la conversación*/
            break;

        buf[0].mtext[strcspn(buf[0].mtext, "\n")] = '\0';
        sscanf(buf[0].mtext, "%s %[^\n]",command, arg);

        if(PID>0){/*Solo envia mensaje cuando se obtiene el PID, es decir cuando se esta conectado*/
          sprintf(name, "%ld",PID);
          if(strcasecmp(buf[0].mtext,"disconnect")==0){ /*Si envio un "disconnect", me salí del grupo, pero puedo volver a conectarme*/
              PID =-1;/*Dejo indicado que no estoy conectado*/
              printf("Digite 'connect [nombre]' para volver a conectarse al chat grupal.\n");
            }

            if(strcasecmp(command,"file")==0) /*Si recibo un file es para enviar el contenido*/
              file(arg);
            else
              send();/*El envio el mensaje*/
        }
        
        if(strcasecmp(command,"connect")==0 && PID==-1){ /*Solo se puede conectar mientras PID = -1*/
          if(strlen(arg)>0){        
            PID = getpid(); /*Hacer el llamado al SO para obtener el ID del proceso, por ahí es donde escucha*/
            sprintf(name, "%s", arg); /*Guardo el nombre que me puse*/
            sprintf(buf[0].mtext, "%s %ld", command, PID); /*Se le envia el comando y el PID para que el servidor me guarde*/
            printf("Pidiendo conexion %s\n",buf[0].mtext);
            printf("Sea conectado al chat grupal. Digite 'disconnect' para salir.\nPara enviar un archivo Digite 'file [nombre]'\n");
            send();
          }
          else 
            printf("Debe especificar un nombre de usuario\n");
        }
      }
    }
  }
  return NULL;
}

void* recibirMsg(void *args){/*Codigo para recibir mensajes, ejecutado por otro hilo*/
  while(1){
    if(PID>0){/*Solo recibe mensaje cuando se obtiene el PID*/
      if (msgrcv(msqid, &buf[1], SIZE, PID, 0) == -1) {/*Obtener el mensaje de la cola con el identificador*/
        break;
      }
      printf("%s\n",buf[1].mtext);/*Imprimo el mensaje que llega*/
      if(strcasecmp(buf[1].mtext,"Grupo cerrado")==0) /*Si recibo un "Grupo cerrado", se termina la conversación*/
        break;

      if(strcasecmp(buf[1].mtext,"Grupo lleno")==0){ /*Si el grupo esta lleno, me desconecto automaticamente*/
        PID =-1;
        printf("Digite 'connect [nombre]' para volver a conectarse al chat grupal.\n");
      }
    }
  }
  PID=-1;
  return NULL;
}

void initializeCola(){/*Conectar a la cola que ya fue creada*/
  key_t key;
  system("touch msgq.txt");
  
  if ((key = ftok("msgq.txt", 'A')) == -1) { /*Crear clave unica*/
    perror("ftok: ");
    exit(EXIT_FAILURE);
  }
  
  if ((msqid = msgget(key, PERMS )) == -1) { /*Conectar a la cola de mensajes*/
    perror("msgget: ");
    exit(EXIT_FAILURE);
  }
}

int main(void) {
  PID = -1;
  pthread_t h[2];/* 0 para enviar, 1 para recibir*/
  
  initializeCola();/*Conectarse a la cola creada por el programa principal*/
  
  pthread_create(&h[0], NULL, &enviarMsg,NULL);/*Hilo pendiente de la consola*/
  pthread_create(&h[1], NULL, &recibirMsg,NULL);/*Hilo pendiente de los mensajes*/

  pthread_join(h[0], NULL);
  pthread_join(h[1], NULL);
  
  printf("No puede responder esta conversación\n");/*Si todos los hilos terminan el chat fue cerrado*/
  return EXIT_SUCCESS;
}


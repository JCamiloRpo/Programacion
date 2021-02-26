
import edu.princeton.cs.algs4.Bag;
import edu.princeton.cs.algs4.In;
import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;

public class Contactos {
	private BusquedaSimilares lista=new BusquedaSimilares();
	private String[][] contactos;
	
	public Contactos(String ruta) { //Constructor
		In Arc = new In(ruta); //Archivo
		String[] lineas;
		
		lineas = Arc.readAllLines(); //Leerlo todo, cada posicion es una linea
		Arc.close();
		String[] aux;
		contactos = new String [lineas.length][2];
		
		for(int i=0;i<lineas.length;i++) {
			aux=lineas[i].split(","); // Nombre,Numero
			lista.add(aux[0]); //Se agregan los nombres
			contactos[i][0] = aux[0];
			contactos[i][1] = aux[1];
		}
	}
	
	public String obtener(String contacto) {
			for(String[] i: contactos) {
				if(i[0].equals(contacto)) {
					return i[0] + ": " + i[1];
				}
			}
			return null;
	}
	
	public Bag<String> buscar(String txt){
		return lista.get(txt);
	}
	
	public static void main(String[] args) {
		try {
			Contactos contactos;
			if(args.length == 0) contactos=new Contactos(".\\Contactos.txt");
			else contactos=new Contactos(args[0]);
			
			int Nro, opc=0, j;
			do {
				StdOut.println("-------- Ingrese el fragmento de busqueda --------"); //Fragmento de busqueda
				String frag=StdIn.readString(); 
				
				j=0;
				Bag<String> similares = contactos.buscar(frag);//Retornan los nombres similares
				
				if(!similares.isEmpty()) {
					for(String i :similares ) //Retornar nombres similares
						StdOut.println((j++) + ". " + i);
					StdOut.println("-----------------------------------------------\n");
					//El usuario selecciona un nombre y se presentan los datos correspondientes
					StdOut.println("--- Ingrese el numero de contacto que desea buscar ---");
					Nro = StdIn.readInt();
					if(Nro < j && Nro >= 0) {
						j=0;
						for(String i:similares) {
							if(Nro == (j++)) {
								StdOut.println(contactos.obtener(i)); //Retornar datos correspondientes
								StdOut.println("-----------------------------------------------\n");
								break;
							}
						}
					}
					else StdOut.println("------ Contacto seleccionado incorrecto ------\n");
				}
				else StdOut.println("-- No existen contactos con esas caracteristicas --\n");
				
				StdOut.println("0. Continuar \nOtro. Finalizar");
				opc = StdIn.readInt();
				
			}while(opc == 0);
			StdOut.println("Fin del Programa");
		}
		catch(Exception e) {
			StdOut.println(e.getMessage());
		}
		
	}
}

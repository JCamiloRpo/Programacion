/*
 * Juan Camilo Restrepo - 000373886
 * Andres Felipe Diaz G - 000331011
 * Carolina Monsalve  - 000367045
 */

import java.util.Iterator;
import edu.princeton.cs.algs4.Bag;

public class BusquedaSimilares implements IBusquedaSimilares {
	private Bag<String> coleccion;
	
	public BusquedaSimilares() { //Constructor vacio
		coleccion=new Bag<String>();
	}
	
	public BusquedaSimilares(String[] pats) { //Constructor lleno
		coleccion=new Bag<String>();
		for(int i=0;i<pats.length;i++)
			coleccion.add(pats[i]);
	}
	
    public Bag<String> get(String pat){ //Algoritmo Extraido de Brute.java from 5.3 Substring Search de Algorithms, 4th Edition.
        Bag<String> similares=new Bag<String>();
        String txt;
        pat = pat.toUpperCase(); //Convertir a mayusculas
        int m = pat.length();
        for(String t: coleccion) { //Obtener los items de la coleccion
        	txt = t.toUpperCase(); //Convertir a mayusculas
        	int n = txt.length();
            for(int i = 0; i <= n-m; i++) { //Se compara con el item t para buscar la similar
                int j;
            	for(j = 0; j < m; j++)
                    if(pat.charAt(j) != txt.charAt(i+j))
                    	break;
                if(j==m) {
                	similares.add(t);
                	break;
                }
            }
        }
        return similares;
    }
        
	public void add(String pat) { //Añadir item a la coleccion
		coleccion.add(pat);
	}
	
	public void add(String[] pats) { //Añadir items a la coleccion
		for(int i=0;i<pats.length;i++)
			coleccion.add(pats[i]);
	}
	
	public Iterator<String> similares(String pat){ //Devolver un iterador sobre la bolsa que retorna get segun las coincidencias	
	 	return get(pat).iterator();
	}
}
	

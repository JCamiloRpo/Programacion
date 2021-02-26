/*
 * Juan Camilo Restrepo - 000373886
 * Andres Felipe Diaz G - 000331011
 * Carolina Monsalve  - 000367045
 */

import java.util.Iterator;
import edu.princeton.cs.algs4.Bag;

public interface IBusquedaSimilares {
	public Bag<String> get(String pat);		// Devuelve un conjunto de terminos similares al parametro de entrada.
	public void add(String pat);	// Agrega un termino al conjunto.
	public void add(String[] pats);		//  Agrega una coleccion de terminos.
	public Iterator<String> similares(String pat);		//Iterador sobre un conjunto de terminos similares al parametro de entrada.
}

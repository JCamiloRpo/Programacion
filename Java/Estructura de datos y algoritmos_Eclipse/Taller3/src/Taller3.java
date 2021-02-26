/*
 * Juan Camilo Restrepo Velez 000373886
 * Andres Felipe Diaz G. 000331011
 * Carolina Monsalve Vasquez 000367045
 */
import edu.princeton.cs.algs4.StdDraw;
import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;
import edu.princeton.cs.algs4.Stopwatch;

public class Taller3 {
	
	public static double[][] points(int n) {//n es el numero total de puntos a generar
		StdRandom.setSeed((int) (StdRandom.uniform()*1000)); //Recalcular un numero semilla aleatorio
    	double[][] datapoints = new double[n][2];
        double[] mu = new double[2], sigma = new double[2]; //Parametros para garantizar mayor aletoriedad
        for(int i=0; i<n; i++) {
        	for(int j=0; j <2; j++) { // Dos repeticiones, una para la X y la otra para Y
        		mu[j] = 2*(StdRandom.uniform() - 0.5);
                sigma[j] = StdRandom.uniform() / 3;
                datapoints[i][j] = StdRandom.gaussian(mu[j], sigma[j]);
        	}
        }
        return datapoints;
    }

    public static void plot(double[][] datapoints) { //Graficar todos los puntos sin cluster
        StdDraw.setScale(-2,2);
        StdDraw.setPenRadius(0.01);
        StdDraw.setPenColor(StdDraw.BLACK);
        for(int i=0; i<datapoints.length; i++)
            StdDraw.point(datapoints[i][0], datapoints[i][1]);
    }
    
    public static void plot(double[][] datapoints, int[][] clusters) throws Exception { //Graficar puntos con sus clusters
    	int r=0,g=0,b=0,cr=0,cg=0,cb=0; //Variables r,g ,b para decidir el color y cr, cg, cb como contadores para controlar el aumento del numero
    	//Vector con los colores disponibles para los clusters
    	StdDraw.setScale(-2,2);
    	StdDraw.setPenRadius(0.01);
        int[] aux = new int [clusters.length-1]; //Vector auxiliar que sirve para saber qu� punto ya fue graficado
    	for(int i=0; i < aux.length; i++) 
    		aux[i]=0;
    	
    	for(int i=0,c=0; i < aux.length; i++){ //c ayuda para saber cuando se utiliza un color
        	if(c == 1) { //Si esta en 1 es porque se utiliz� un color y aumenta k para el proximo cluster
        		if(cr == 4 && cg == 4 && cb == 4) //los contadores van desde el 0 hasta el 4
    				throw new Exception("No hay suficientes colores para que cada cluster tenga uno diferente (max 125 color-cluster)");
        		else {
        			/* Para cada valor de cr (0-4), cg va desde 0 - 4 y para cada de este cb va desde 0 - 4, es decir
        			 * para cr=0 -> cg = 0 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 1 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 2 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 3 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 4 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 		cr=1 -> cg = 0 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 1 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 2 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 3 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * 				cg = 4 -> cb = 0, cb = 1, cb = 2, cb = 3, cb = 4
        			 * ... y asi hasta que cr = 4 y cg = 4 y cb = 4
        			 * Garantizando hasta 125 colores
        			 */
        			if(cg == 4 && cb == 4) {
            			cr++;
            			cg=0;
        				cb=0;
            		}
        			else if(cb == 4) {
        				cg++;
        				cb=0;
        			}
        			else
        				cb++;
        		}
        		r = 64*cr > 255 ? 255: 64*cr;
        		g = 64*cg > 255 ? 255: 64*cg;
        		b = 64*cb > 255 ? 255: 64*cb;
        	}
        	c=0;//Inicializo
        	
        	for(int j=0; j < aux.length; j++) { 
    			if(clusters[i][0] == clusters[j][0]) { //Para buscar todos los puntos que pertenezcan al mismo cluster que el punto i
    				if(aux[j] == 0) { //La posicion que aun este en 0 es porque aun no se a graficado
    					StdDraw.setPenColor(r,g,b);
    					StdDraw.point(datapoints[j][0], datapoints[j][1]);
    					c=1; //Indico que se ha utilizado un color
    					aux[j] = 1; //Cambio el valor por 1 para indicar que ya se grafic�
    				}
    			}
        	}
        }
    }
    
    public static int[][] clusters(double[][] data, double DMAX){
    	int[][] cluster = new int[data.length + 1][1]; //Vector a retornar
    	int idp,idq; //Variables para minimizar el numero de accesos al arreglo durante los fors
    	double idpx,idpy,idqx,idqy,qx,qy;
    	double D = 0, DAUX = 0; //D - distancia de la raiz de un cluster nuevo al punto, DAUX - distancia de la raiz del cluster actual al punto
    	int N = data.length;//Numero de cluster iniciales
    	for(int i=0; i < data.length; i++) //Inicializar clusters
    		cluster[i][0] = i;
    	
    	for(int p = 0; p < data.length; p++) {
    		idp = cluster[p][0]; //Id del Cluster nuevo
    		idpx = data[idp][0]; //X del cluster que pertenece p
    		idpy = data[idp][1]; //Y del cluster que pertenece p
    		for(int q = 0; q < data.length && N > 1; q++) { //Hallar la distancia del cluster del punto p con todos los puntos q y si N == 1 ya estan unidos todos los puntos
    			idq = cluster[q][0]; //Cluster actual de q
    			qx = data[q][0]; // X de q
    			qy = data[q][1]; // Y de q
    			D = Math.sqrt( (idpx-qx)*(idpx-qx) + (idpy-qy)*(idpy-qy)); //La distancia del punto q con su posible nuevo cluster idp
	    		if(D <= DMAX) { //Si la distancia cumple con la distancia maxima, puede ocurrir que ya estuviera en un cluster o apenas va a uno
	    			//Se debe comparar si el punto ya no esta en su cluster inicial para comparar las distancias del actual con el nuevo cluster
	    			if( idq != q ) { //Si no se realiza esta comparaci�n al calcular DAUX ser� cero y siempre se dejar� el cluster inicial
	    				idqx = data[idq][0]; //X del cluster actual que pertenece q
	        			idqy = data[idq][1]; //Y del cluster actual que pertenece q
	    				DAUX = Math.sqrt( (idqx-qx)*(idqx-qx) + (idqy-qy)*(idqy-qy)); //la distancia del punto q a  su cluster actual
	    				if(D < DAUX) //Si la distancia al nuevo cluster es menor que la del actual hago el intercambio de clusters, si no queda con el mismo id de cluster que tenia
	    					cluster[q][0] = idp;
	    			}
	    			else if(idp == p && idq != idp ){ //Si estaba en el cluster inicial Y no tiene el mismo cluster (para no sobre escribir los clusters) lo cambio por el nuevo
	    				N--; //Cada que se une un punto con otro inicialmente se decrementa
	    				cluster[q][0] = idp;
	    			}
	    		}
    		}
    	}
    	cluster[data.length][0] = N;
    	return cluster;
    }
    
    private static double medirClusters(double DMAX, double[][] points) {
    	Stopwatch time = new Stopwatch();
        clusters(points, DMAX);
		return time.elapsedTime();
    }
    
    public static void main(String[] args) {
        try {
        	
        	StdOut.println("Ingrese el numero de puntos");
        	int N = StdIn.readInt();
        	StdOut.println("Ingrese la distancia maxima");
        	double DMAX= StdIn.readDouble();
        	double[][] datapoints = points(N); //Generar puntos
            int[][] cluster = clusters(datapoints, DMAX); //Enviar puntos, DMAX y obtener los clusters
            int C = cluster[N][0]; //El numero de cluster est� en la posicion N+1
            StdOut.println("Total clusters "+C);
			plot(datapoints, cluster); //Enviar los puntos y sus clusters
			/*
        	//Toma de medicion de tiempo
        	int N = 1000000;
        	double[][] points = points(N);
        	for(int i=0;i<10;i++)
        		StdOut.println(medirClusters(0.5,points));
        	*/
		} catch (Exception e) {
			e.printStackTrace();
		}
    }
}

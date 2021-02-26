using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Juan Camilo Restrepo Velez - 000373836
 Imprimir submatrices 2x2 en sentido horario de una matriz 5x5
 */
namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random nro = new Random();
                int[,] matriz = new int[5, 5];
                bool fin = true;
                int j = 0, i = 0, k=0, m=0;
                
                for (j = 0; j <= 4; j++)
                {
                    for (i = 0; i <= 4; i++)
                    {
                        matriz[j, i] = nro.Next(18, 81);
                        Console.Write(matriz[j,i] + "|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                i = 0;
                j = 0;
                //j controla las filas e i las columnas de la matriz 5x5
                k = 1;
                m = 1;
                //k y m controlan la ultima posición a la que va llegando la matriz 2x2, k es la fila y me la columna
                while (fin)
                {
                    Console.Write(matriz[j,i] + "|");

                    if(m == 5 && k == 5 && i == 4 && j == 0) //Condición para terminar el ciclo, que seria en la ultima matriz 2x2 y ultima posición
                        fin = false;
                    if(i == (m-1) && (j == k || (k == 5 && j == 0))) //Condición para seguir a la proxima 2x2
                    {
                        if(m==5) //Condición para seguir a la 2x2 de la siguiente fila de la 5x5 (k aumenta)
                        {
                            k++;
                            m=1;
                            j=k-1;
                            i=m-1;
                            Console.WriteLine();
                        }
                        else //Sino la siguiente 2x2 de la proxima columna de la 5x5 (m aumenta)
                        {
                            i= m;
                            j= k-1;
                            m++;
                            Console.WriteLine();
                        }
                    }
                    else if (i == m) // Condición para bajar a la segunda fila de la 2x2
                    {
                        if(k == 5) // Si esta en la ultima fila de la 5x5, para ir a la primera fila de esta
                        {
                            if(j == 0) i = m-1; 
                            else j = 0;
                        }
                        else if (j == k) i = m-1;
                        else j = k;
                        // Se baja y luego se retrocede para seguir en sentido horario
                    }
                    else if(m == 5 && k == 5) // Para conocer que esta en la ultima posición de la 5x5
                    {
                        // Se imprime primero la esquina inferior derecha de la 5x5
                        if(i==0 && j==0) i=4; //imprime tercero la esquina superior derecha de la 5x5
                        else if(i==0)j=0; //imprime tercero la esquina superior izquierda de la 5x5
                        else i=0; // imprime segundo la esquina inferior izquierda de la 5x5
                    }
                    else if(m == 5) // Si esta en la ultima columna de la 5x5, para ir a la primera columna esta
                    {
                        if(i==0 && j==k) i=4; // 3- Va a la ultima columna
                        else if(i==0)j=k; // 2- baja de fila
                        else i=0; // 1- Va la primera columna de la 5x5
                    }
                    else i++;
                }
                Console.ReadKey();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("El error general es: " + e);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Fin de la ejecucion");
            }
        }         
    }
}

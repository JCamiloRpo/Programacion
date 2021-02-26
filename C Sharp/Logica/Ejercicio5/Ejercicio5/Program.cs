using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Juan Camilo Restrepo Velez - 000373886
 * Recibe un string y hay que hallar el camino de la posicion inicial a la ultima posicion de una matriz 5x5
 */
namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool seguir = true;
                string entrada = " ";
                string[,] tablero = new string[5, 5];
                int[] s = { 0, 0 }, b = { 0, 0 }, d = { 0, 0 }, i = { 0, 0 }; 
                /* La posicion 0 es para saber cuantas veces seguidas esta la letra
                 * La posicion 1 es para contar cuantas veces esta en total.
                 */
                int si = 0; //Para saber cuantas veces seguidas esta el signo

                for (int k = 0; k <= 4; k++)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        tablero[k, j] = " ";
                    }
                }

                do
                {
                    Console.WriteLine("Ingrese la palabra de entrada: ");
                    entrada = (Console.ReadLine()).ToLower();
                    if (entrada.Length < 8 || entrada.Length > 25) Console.WriteLine("La palabra debe ser mayor de 7 y menor de 25");
                } while (entrada.Length < 8 || entrada.Length > 25); //Hasta que se cumpla la condicion no se para de pedir la palabra

                for(int k = 0; k <= entrada.Length - 1; k++) //Recorro la palabra para saber si esta bien
                {
                    switch (entrada[k])
                    {
                        case 's':
                            s[0]++;
                            s[1]++;
                            b[0] = 0;
                            d[0] = 0;
                            i[0] = 0;
                            si = 0;
                        break;
                        case 'b':
                            b[0]++;
                            b[1]++;
                            s[0] = 0;
                            d[0] = 0;
                            i[0] = 0;
                            si = 0;
                        break;
                        case 'd':
                            d[0]++;
                            d[1]++;
                            b[0] = 0;
                            s[0] = 0;
                            i[0] = 0;
                            si = 0;
                            break;
                        case 'i':
                            i[0]++;
                            i[1]++;
                            b[0] = 0;
                            d[0] = 0;
                            s[0] = 0;
                            si = 0;
                            break;
                        case '?':
                            si++;
                            b[0] = 0;
                            d[0] = 0;
                            s[0] = 0;
                            i[0] = 0;
                            break;
                        default:
                            seguir = false;
                        break;
                    }
                    
                }
                //Si alguna letra esta mas de 4 veces seguida no se puede hallar la palabra, si hay una letra no valida o si se inicia con ?
                if (s[0] > 4 || b[0] > 4 || d[0] > 4 || i[0] > 4 || entrada[0].Equals("?") || si > 4 || seguir==false)
                {
                    Console.WriteLine("No se puede hallar el camino con la palabra.");
                }
                else //Si toda la palabra esta bien se procede a hallar el camino
                    hallarcamino(entrada, tablero, s, b, d, i); //Se envia la palabra, el tablero y los vectores
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("El error general es: " + e);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }
        public static void hallarcamino(string entrada, string[,] tablero, int[] s, int[] b, int[] d, int[] i)
        {
            try
            {
                int k = 0, f = 0, c = 0; //k para recorrer la palabra. f para saber en cual fila estoy y c para saber en cual columna
                string salida = "";
                bool fin = false;
                for (k = 0; k <= entrada.Length - 1; k++)
                {
                    switch (entrada[k])
                    {
                        case 's':
                            if (f == 0) fin = true;
                            else if (tablero[f - 1, c].Equals(" ")) //Condicion para ir arriba
                            {
                                f--;
                                s[1]--; //Elimino la vez que subió
                                tablero[f, c] = "s"; //Escribo en el tablero el movimiento
                                salida = salida + "s"; //Concateno la salida
                            }
                            else fin = true;
                            break;
                        case 'b':
                            if (f == 4) fin = true;
                            else if (tablero[f + 1, c].Equals(" ")) //Condicion para ir a bajo
                            {
                                f++;
                                b[1]--; //Elimino la vez que bajó
                                tablero[f, c] = "b"; //Escribo en el tablero el movimiento
                                salida = salida + "b";//Concateno la salida
                            }
                            else fin = true;
                            break;
                        case 'd':
                            if (c == 4) fin = true;
                            else if (tablero[f, c + 1].Equals(" ")) //Condicion para ir a la derecha
                            {
                                c++;
                                d[1]--; //Elimino la vez que fue a la derecha
                                tablero[f, c] = "d"; //Escribo en el tablero el movimiento
                                salida = salida + "d";//Concateno la salida
                            }
                            else fin = true;
                            break;
                        case 'i':
                            if (c == 0) fin = true;
                            else if (tablero[f, c - 1].Equals(" ")) //Condicion para ir a la izquierda
                            {
                                c--;
                                i[1]--; //elimino la vez que fue a la izquierda
                                tablero[f, c] = "i"; //Escribo en el tablero el movimiento
                                salida = salida + "i";//Concateno la salida
                            }
                            else fin = true;
                            break;
                        case '?':
                            if(f == 4 && c == 0) //Si esta en la ultima fila, solo puede ir a la derecha
                            {
                                if (tablero[f, c + 1].Equals(" ")) //Condicion para ir a la derecha
                                {
                                    c++;
                                    tablero[f, c] = "d"; //Escribo en el tablero el movimiento
                                    salida = salida + "d";//Concateno la salida
                                }
                                else fin = true; //Si no puede se acabó
                            }
                            else if(f == 0 && c == 4) //Si esta en la ultima columna solo puede ir abajo
                            {
                                if (tablero[f + 1, c].Equals(" ")) //Copndicion para bajar
                                {
                                    f++;
                                    tablero[f, c] = "b"; //Escribo en el tablero el movimiento
                                    salida = salida + "b";//Concateno la salida
                                }
                                else fin = true; //Si no puede se acabó
                            }
                            else if(f < b[1] && f > 0)  //Si la fila en la que esta es menor que las veces que debe bajar, sube
                            {
                                if (tablero[f - 1, c].Equals(" ")) //Condicion para subir
                                {
                                    f--;
                                    tablero[f, c] = "s"; //Escribo en el tablero el movimiento
                                    salida = salida + "s";//Concateno la salida
                                }
                                else fin = true; //Si no se puede se acabó
                            }
                            else if (f > b[1] && f < 4) //Si la fila en la que esta es mayor que las veces que debe bajar, baja
                            {
                                if (tablero[f + 1, c].Equals(" ")) //Condicion para bajar
                                {
                                    f++;
                                    tablero[f, c] = "b"; //Escribo en el tablero el movimiento
                                    salida = salida + "b";//Concateno la salida
                                }
                                else fin = true; //Si no se puede se acabó
                            }
                            else if (c < d[1] && c > 0) //Si la columna en la que esta es menor que las veces que debe ir a la derecha, va a la izquierda
                            {
                                if (tablero[f, c - 1].Equals(" ")) //Condicion para ir a la izquierda
                                {
                                    c--;
                                    tablero[f, c] = "i"; //Escribo en el tablero el movimiento
                                    salida = salida + "i";//Concateno la salida
                                }
                                else fin = true; //Si no se puede se acabó
                            }
                            else if (c > d[1] && c < 4) //Si la columna en la que esta es mayor que las veces que debe ir a la derecha, va a la derecha
                            {
                                if (tablero[f, c + 1].Equals(" ")) //Condicion para ir a la derecha
                                {
                                    c++;
                                    tablero[f, c] = "d"; //Escribo en el tablero el movimiento
                                    salida = salida + "d"; //Concateno la salida
                                }
                                else fin = true; //Si no se puede se acabó
                            }
                            break;
                        default:
                            break;
                    }
                    if (fin || (entrada.Length == salida.Length && f < 4 && c < 4)) //Condicion para saber si no se puede llegar a la ultima posicion
                    {
                        Console.WriteLine("No se puede hallar el camino con la palabra.");
                        k = entrada.Length;
                    }
                }
                if (fin == false && f == 4 && c == 4)
                {
                    for (k = 0; k <= 4; k++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            Console.Write(tablero[k, j] + "|");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine(salida);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("El error de la subrutina es: " + e);
                Console.ReadKey();

            }
        }
    }
}

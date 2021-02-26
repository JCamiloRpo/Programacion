using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Juan Camilo Restrepo Velez - 000373836
 Imprimir verdadero o falso si entre dos numeros que sumen 10 hay exactamente 3 signos de interrogación
 */
namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random al = new Random();
                char[,] matriz;
                int j = 0, i = 0, f = 0, c = 0; //f para ingresar la cantidad de filas y c para la cantidad de colunmas
                
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese la cantidad de filas de la matriz");
                        f = Convert.ToInt16(Console.ReadLine());
                        if(f <= 2) Console.WriteLine("El valor de las filas debe ser mayor que 2");
                    }
                    catch(Exception ef)
                    {
                        Console.WriteLine("No se ingresó un valor valido para la cantidad de filas");
                        f=0;
                    }
                } while (f <= 2); //Controlo los datos ingresados para evitar errores
                
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
                        c = Convert.ToInt16(Console.ReadLine());
                        if(c <= 2) Console.WriteLine("El valor de las columnas debe ser mayor que 2");
                    }
                    catch(Exception ec)
                    {
                        Console.WriteLine("No se ingresó un valor valido para la cantidad de clumnas");
                        c=0;
                    }
                } while (c <= 2); //Controlo los datos ingresados para evitar errores
                
                matriz = new char[f, c];
                for (i = 0; i <= f - 1; i++)
                {
                    for (j = 0; j <= c - 1; j++)
                    {
                        //LLeno matriz de las letras aleatoriamente entre mayusculas y minusculas
                        if (al.Next(0, 2) == 0) matriz[i, j] = Convert.ToChar(al.Next(65, 91));
                        else matriz[i, j] = Convert.ToChar(al.Next(97, 123));
                        Console.Write(matriz[i, j] + "|");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                cuadrovocales(matriz, f, c); //Envio la matriz y la cantidad de filas y columnas
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

        static public string cuadrovocales(char[,] matriz, int f, int c)
        {
            try
            {
                string resul = "No encontrado";
                bool no = true, fin = true, v = false; //"no" para saber si almenos una 2x2 tiene las vocales. "v" para validar las cuatro vocales de la 2x2
                int i = 0, j = 0, m = 1, k = 1, cont = 0; //j y i hacen las vaces de la matriz 2x2. m y k los limites de la matriz 2x2
                while (fin) //Ciclo para recorrer la matriz con las letras
                {
                    if (v) //Entra cuando ya se hizo una matriz 2x2
                    {
                        Console.WriteLine(cont);
                        if (cont == 4)
                        {
                            Console.WriteLine((i - 1) + " - " + (j - 1));
                            no = false; //Como si habia una matriz 2x2 ya no se muestra el mensaje resul
                        }
                        cont = 0; //Se deja las variables como estaban para iniciar el analisis
                        v = false;
                    }
                    if (matriz[i, j] == 65 || matriz[i, j] == 69 || matriz[i, j] == 73 || matriz[i, j] == 79 || matriz[i, j] == 85 ||
                       matriz[i, j] == 97 || matriz[i, j] == 101 || matriz[i, j] == 105 || matriz[i, j] == 111 || matriz[i, j] == 117)
                        cont++; //Si en la posicion hay una vocal mayuscula o minuscula cont aumenta uno
                    if (m == f && k == c && i == 0 && j == 0) fin = false; //Condicion para salir del ciclo
                    if ((i == m || (i == 0 && m == f)) && (j == k || (j == 0 && k == c)))
                    {
                        
                        v = true; //Para ingresar a la validación de las vocales
                        if (k == c) //Si las columnas estan al final de la matriz mayor se baja de fila
                        {
                            m++;
                            k = 1;
                            i = m - 1;
                            j = k - 1;
                        }
                        else //Sino se sigue a la columna contigua
                        {
                            k++;
                            j = k - 1;
                            i = m - 1;
                        }
                    }
                    else if (j == k) // Para bajar de fila de la 2x2
                    {
                        if (m == f) // si la 2x2 esta en la ultima fila, se sube a la primera
                        {
                            i = 0;
                            j = k - 1;
                        }
                        else // Sino se baja a la siguiente fila de la 2x2
                        {
                            j = k - 1;
                            i = m;
                        }
                    }
                    else if (m == f && k == c) //Si las filas y columnas de la 2x2 estan al final de la matriz mayor
                    {
                        if (j == (k - 1) && i == 0) j = 0; //Se situa en la posicion 0-0 de la matriz mayor
                        else if (j == 0) //Se situa en la posicion 0- (ultima columna) de la matriz mayor
                        {
                            i = 0;
                            j = k - 1;
                        }
                        else j = 0; //Se situa en (ultima fila) - 0 de la matriz mayor
                    }
                    else if (k == c) //Si la columna de la 2x2 esta en la ultima de la matriz mayor
                    {
                        if (j == (k - 1) && i == m) j = 0; //Se pone en la primera columna de la matriz mayor y en la ultima fila de la 2x2
                        else if (j == 0) //Se pone en la penultima columna de la matriz mayor y en la ultima fila de la 2x2
                        {
                            i = m;
                            j = k - 1;
                        }
                        else j = 0; //Se devuelve a la primera columna
                    }
                    else j++;
                }
                if (no) Console.WriteLine(resul);
                return "Fin";
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina es: " + e);
                Console.ReadKey();
                return "0";
            }
        }
    }
}

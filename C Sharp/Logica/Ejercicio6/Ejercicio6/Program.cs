using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Juan Camilo Restrepo Velez - 000373886
 * Alcanzar el enemigo mas cercano
 */
namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] vector;
                int n = 0;
                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese el tamaño de la matriz nxn");
                        n = Convert.ToInt16(Console.ReadLine());
                        if (n <= 2) Console.WriteLine("El tamaño de la matriz debe ser mayor que 2");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("No se ingresó un tipo de numero valido");
                        Console.ReadKey();
                    }                  
                } while (n <= 2); //Valido que la cantidad de filas y columnas sea correcta
                vector = new string[n];

                for(int i=0; i < n; i++)
                {
                    Console.WriteLine("Escriba la fila " + (i + 1) + " de la matriz (Recuerde que solo puede haber una X y deben hacer "+n+" caracteres)");
                    vector[i] = (Console.ReadLine()).ToUpper(); //Pido la infomacion de las filas de la matriz
                }
                validar(vector,n); //Envia para validar los caracteres entrados anteriormente
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("El error general es: " + e);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }
        public static void validar(string[] vector, int n)
        {
            try
            {
                bool b = false;
                int x = 0, y = 0; //x para saber cuantas x hay y y para saber cuantas y hay
                int[] vx = { 0, 0 }, vy = { 0, 0 }; //vx para guarta la posicion de x y vy para guardar la de la y mas cercana a x
                var ly = new List<int> { }; //Para ir guardando las posiciones de todas las y que hay
                for(int i = 0; i <= n - 1; i++)
                {
                    for(int j=0; j <= n - 1; j++)
                    {
                        if (vector[i].Length == n) //Validos que la cantidad de caracteres sea igual a la cantidad de columnas de la matriz
                        {                           
                            switch (vector[i][j])
                            {
                                case 'O': //Si es O no hace nada
                                break;
                                case 'X': //Si es X, guarda la posicion y cuenta que ya hay una x
                                    x++;
                                    vx[0] = i;
                                    vx[1] = j;
                                break;
                                case 'Y': //Si es Y, guarda la posicion y cuenta las y
                                    y++;
                                    ly.Add(i);
                                    ly.Add(j);
                                break;
                                default: //Si hay otro caracter se sale y marca error
                                    b = true;
                                    i = n;
                                    j = n;
                                break;
                            }
                        }
                        else //Si la cantidad de caracteres de la palabra no es igual a la cantidad de columnas se sale
                        {
                            b = true;
                            i = n;
                            j = n;
                        }
                    }
                }
                if (x == 0 || x > 1 || y == 0) b = true; //Condicion para terminar el programa por inconsistencia de datos
                if (b) Console.WriteLine("Hay un error con las letras digitadas");
                else
                {
                    vy[0] = ly[0]; //Guardo posicion dela primera y
                    vy[1] = ly[1];
                    for (int i=2; i <= y-1; i=i+2)  //Ciclo de todas las y que hay
                    {
                        if((vx[0]-ly[i]) < (vx[0] - vy[0])) //Condicion para saber cual y esta mas cerca a x en las filas
                            vy[0] = ly[i];
                        if ((vx[1] - ly[i+1]) < (vx[1] - vy[1])) //Condicion para saber cual y esta mas cerca a x en las filas
                            vy[1] = ly[i+1];
                    }
                    
                    llenar(vector, n, vy, vx); //Envio los datos para llenar la matriz
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina validar es: " + e);
                Console.ReadKey();
            }
        }
        public static void llenar(string[] vector, int n, int[] vy, int[] vx)
        {
            try
            {
                string[,] matriz = new string[n, n];
                Console.WriteLine();
                Console.WriteLine("Inicial");
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        matriz[i, j] = Convert.ToString(vector[i][j]);
                        Console.Write(matriz[i, j] + "|");
                    }
                    Console.WriteLine();
                } //Despues de llenar la matriz, envio los datos para alcanzar el enemigo
                alcanzarenemigo(matriz, n, vy, vx);
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina llenr es: " + e);
                Console.ReadKey();
            }
        }
        public static void alcanzarenemigo(string[,] matriz, int n, int[] vy, int[] vx)
        {
            try
            {
                int cont = 0, aux=0; //Cont para contar los pasos que van y aux para guardar la diferencia de las posiciones de x y y
                double m = n/2; //m para tomar una decision de subir o bajar, de ir a la derecha o a la izquierda
                bool fin = true;
                while (fin)
                {
                    if (((vx[0] - vy[0]) == 0) || fin == false) ; //Si la diferencia entre las filas es cero ya no se mueve hacia arriba ni abajo
                    else
                    {
                        matriz[vx[0], vx[1]] = " "; //Se pone en blanco la posicion en la que estaba X
                        //Acomodo la diferencia de forma que no quede negativa y la guardo en la aux
                        if (vx[0] > vy[0]) aux = vx[0] - vy[0];
                        else aux = vy[0] - vx[0];

                        if ((aux >= Math.Round(m)) || vx[0] > vy[0])
                            // Si la aux es mayor o igual a la mitad de filas entre 2, o x esta mas abajo que y, sube
                        {
                            if (vx[0] == 0) vx[0] = n - 1; //Si esta en la primera fila, va a la ultima
                            else vx[0]--; // Si no sube
                        }
                        else
                        {
                            if (vx[0] == (n - 1)) vx[0] = 0; //Si esta en la ultima fila, sube a la primera
                            else vx[0]++; //Si no baja
                        }
                        if (matriz[vx[0], vx[1]].Equals("Y")) //Si la matriz en al nueva posicion de x habia una y concatena y termina
                        {
                            matriz[vx[0], vx[1]] += "X";
                            fin = false;
                        }
                        else matriz[vx[0], vx[1]] = "X"; //Si no solo se pone x
                        cont++; //Se cuenta un paso
                        Console.WriteLine();
                        Console.WriteLine("Paso: " + cont);
                        mostrar(matriz, n); //Se envia a una subrutina para mostrar el paso
                    }
                    if (((vx[1] - vy[1]) == 0) || fin==false) ; //Si la diferencia entre las columnas es cero ya no se mueve hacia la derecha ni a la izquierda
                    else
                    {
                        matriz[vx[0], vx[1]] = " "; //Se pone en blanco la posicion en la que estaba X
                        //Acomodo la diferencia de forma que no quede negativa y la guardo en la aux
                        if (vx[1] > vy[1]) aux = vx[1] - vy[1];
                        else aux = vy[1] - vx[1];

                        if ((aux <= Math.Round(m)) || vx[1] < vy[1])
                        // Si la aux es menor o igual a la mitad de filas entre 2, o x esta mas a la izquierda que y, va a la izquierda
                        {
                            if (vx[1] == 0) vx[1] = n - 1; //Si esta en la primera columna, va a la ultima
                            else vx[1]--; //Si no va a la izquierda
                        }
                        else
                        {
                            if (vx[1] == (n - 1)) vx[1] = 0; //Si esta en ultima columna, va a la primera
                            else vx[1]++; //Si no va a la derecha
                        }
                        if (matriz[vx[0], vx[1]].Equals("Y"))//Si la matriz en al nueva posicion de x habia una y concatena y termina
                        {
                            matriz[vx[0], vx[1]] += "X";
                            fin = false;
                        }
                        else matriz[vx[0], vx[1]] = "X";//Si no solo se pone x
                        cont++;//Se cuenta un paso
                        Console.WriteLine();
                        Console.WriteLine("Paso: " + cont);
                        mostrar(matriz, n);//Se envia a una subrutina para mostrar el paso
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina alcanzar enemigo es: " + e);
                Console.ReadKey();
            }
        }
        public static void mostrar(string[,] matriz, int n)
        {
            try
            {
                for (int i = 0; i <= n - 1; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        Console.Write(matriz[i, j] + "|");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina llenr es: " + e);
                Console.ReadKey();
            }
        }
    }
}

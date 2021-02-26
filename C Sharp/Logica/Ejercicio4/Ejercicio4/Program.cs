using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Juan Camilo Restrepo Velez - 000373886
 * Balancear pesos de un vector balanza con los datos de un vector pesos
 */
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random al = new Random();
                int[] balanza = { al.Next(1,11), al.Next(1, 11) }, pesos = new int[5]; //LLeno la balanza y doy el tamaño del vector pesos
                Console.WriteLine("Balanza: " + balanza[0] + "|" + balanza[1] + "|");
                Console.Write("Pesos: ");

                for (int i = 0; i <= 4; i++)
                {
                    pesos[i] = al.Next(1, 11); //Lleno el vector pesos
                    Console.Write(pesos[i] + "|");

                }

                Console.WriteLine();
                balanceo(balanza,pesos); //Envio los dos parametros de la subrutina
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
        public static void balanceo(int[] balanza, int[] pesos)
        {
            try
            {
                bool neg = false, dos = false, no = true;
                /* neg para saber si la diferencia de pesos es negativa
                 * dos para saber si necesitos dos numeros para balancear
                 * no para saber si se entró numeros que puedan balancear
                */
                int i = 0, aux1 = 0, aux2 = 0, dife = 0;
                if ((balanza[0] - balanza[1]) < 0) //Hallo la diferencia de la balanza y analizo cual numero es mayor
                {
                    neg = true;
                    dife = balanza[1] - balanza[0]; // Guardo la diferencia
                }
                else dife = balanza[0] - balanza[1];
                for (i = 0; i <= 4; i++)
                {
                    switch (i)
                    {
                        case 0: //Analizo las diferencias de los pesos y las comparo con la diferencia de la balanza, para cada numero del vector pesos
                            if ((pesos[i] - pesos[i + 1]) == dife || (pesos[i + 1] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 1]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 1];
                                }
                                else
                                {
                                    aux1 = pesos[i + 1];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if ((pesos[i] - pesos[i + 2]) == dife || (pesos[i + 2] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 2]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 2];
                                }
                                else
                                {
                                    aux1 = pesos[i + 2];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if ((pesos[i] - pesos[i + 3]) == dife || (pesos[i + 3] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 3]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 3];
                                }
                                else
                                {
                                    aux1 = pesos[i + 3];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if ((pesos[i] - pesos[i + 4]) == dife || (pesos[i + 4] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 4]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 4];
                                }
                                else
                                {
                                    aux1 = pesos[i + 4];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if (pesos[i] == dife)
                            {
                                aux1 = pesos[i];
                                no = false;
                                i = 5;
                            }
                            break;
                        case 1:
                            if ((pesos[i] - pesos[i + 1]) == dife || (pesos[i + 1] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 1]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 1];
                                }
                                else
                                {
                                    aux1 = pesos[i + 1];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if ((pesos[i] - pesos[i + 2]) == dife || (pesos[i + 2] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 2]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 2];
                                }
                                else
                                {
                                    aux1 = pesos[i + 2];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if ((pesos[i] - pesos[i + 3]) == dife || (pesos[i + 3] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 3]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 3];
                                }
                                else
                                {
                                    aux1 = pesos[i + 3];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if (pesos[i] == dife)
                            {
                                aux1 = pesos[i];
                                no = false;
                                i = 5;
                            }
                            break;
                        case 2:
                            if ((pesos[i] - pesos[i + 1]) == dife || (pesos[i + 1] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 1]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 1];
                                }
                                else
                                {
                                    aux1 = pesos[i + 1];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if ((pesos[i] - pesos[i + 2]) == dife || (pesos[i + 2] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 2]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 2];
                                }
                                else
                                {
                                    aux1 = pesos[i + 2];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if (pesos[i] == dife)
                            {
                                aux1 = pesos[i];
                                no = false;
                                i = 5;
                            }
                            break;
                        case 3:
                            if ((pesos[i] - pesos[i + 1]) == dife || (pesos[i + 1] - pesos[i]) == dife)
                            {
                                if ((pesos[i] - pesos[i + 1]) == dife)
                                {
                                    aux1 = pesos[i];
                                    aux2 = pesos[i + 1];
                                }
                                else
                                {
                                    aux1 = pesos[i + 1];
                                    aux2 = pesos[i];
                                }
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            else if (pesos[i] == dife)
                            {
                                aux1 = pesos[i];
                                no = false;
                                i = 5;
                            }
                            break;
                        case 4:
                            if (pesos[i] == dife)
                            {
                                aux1 = pesos[i];
                                no = false;
                                dos = true;
                                i = 5;
                            }
                            break;
                        default:
                            break;
                    }
                }
                /*
                 * Cuando se halle una diferencia que satisface la diferencia a la balaza, saco del ciclo
                 * guardo el numero mayor en el aux1 y el menor (si es necesario) en el aux2
                 * pongo dos = true si se necesitan dos numeros, el no en false porque ya se halló los numeros para balancear
                 */
                if (no == false)
                {
                    //Como se halló los o el numero para balancear analizo los casos que se pueden presentar y sumo los numeros
                    if (dos && neg)
                    {
                        balanza[0] = balanza[0] + aux1;
                        balanza[1] = balanza[1] + aux2;
                    }
                    else if (dos == false && neg)
                        balanza[0] = balanza[0] + aux1;
                    else if (dos && neg == false)
                    {
                        balanza[1] = balanza[1] + aux1;
                        balanza[0] = balanza[0] + aux2;
                    }
                    else if (dos == false && neg == false)
                        balanza[1] = balanza[1] + aux1;
                    if (dos)
                        Console.WriteLine(aux2 + "," + aux1);
                    else
                        Console.WriteLine(aux1);
                }
                else //Si no se encontró un numero no se deja en true y se muestra el mensaje
                    Console.WriteLine("No se pudo balancear.");
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina es: " + e);
                Console.ReadKey();
            }

        }
    }
}

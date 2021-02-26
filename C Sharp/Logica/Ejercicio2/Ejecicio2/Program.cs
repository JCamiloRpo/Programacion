using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Juan Camilo Restrepo Velez - 000373836
 Imprimir verdadero o falso si entre dos numeros que sumen 10 hay exactamente 3 signos de interrogación
 */
namespace Ejecicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string pala = "";
                do
                {
                    Console.WriteLine("Ingrese el texto");
                    pala = Console.ReadLine();
                    if(pala.Length==0)Console.Write("El texto no puede estar vacio, ingrese uno valido. ");
                }while(pala.Length==0);
                
                Console.WriteLine(signos(pala)); //Envio la palabra a la subrutina y de una vez imprimo lo que devuelve
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("El error general es: "+e);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("fin del programa");
            }
        }
        public static string signos(string pala)
        {
            try
            {
                string resul = "Falso";
                int i = 0, n1 = 0, n2 = 0, sum = 0, cont = 0;
                bool r = false, s = false, fin = false;
                while (i >= 0) //Condicion para recorrer la palabra
                {
                    if (pala.ElementAt(i) >= 48 && pala.ElementAt(i) <= 57) // Analizar cuando se encuentre un numero
                    {
                        if (r == false) //r variable para saber si ya tengo el primer numero
                        {
                            n1 = (pala.ElementAt(i)) - 48; //Convierto el numero a decimal
                            r = true; // Identifico que ya está el primer numero
                            s = true; // s para empezar a contar los signos
                        }
                        else
                        {
                            n2 = (pala.ElementAt(i)) - 48; ////Convierto el numero a decimal
                            fin = true; //Identifico que ya están los dos numeros
                        }
                    }
                    else if (s && pala.ElementAt(i) == 63)
                    {
                        cont++; // Cuento los signos
                        
                        if(cont > 3) //Para descartar si ya hay mas de 3 signos
                        {
                            cont = 0;
                            r = false; 
                            s = false;
                        }
                    }
                    
                    if (fin)
                    {
                        sum = n1 + n2; //Sumo los numeros
                        if (sum == 10 && cont == 3) //Valido la suma y los signos
                        {
                            resul = "Verdadero"; //Doy la respuesta
                            i = -1; //Sacó del ciclo
                        }
                        else
                        { //si la suma o los signos no dan, dejó todo como el inicio
                            cont = 0;
                            r = false; 
                            s = false;
                            fin = false;
                        }
                    }
                    else if (i == pala.Length - 1) i = -1; //En caso de llegar al final de la palabra saco del ciclo con la respuesta en false
                    else i++; //Si no se ha llegado al final sigo con el otro caracter
                }
                return resul;
            }
            catch (Exception e)
            {
                Console.WriteLine("El error de la subrutina es: " + e);
                return "0";
            }
        }
    }
}

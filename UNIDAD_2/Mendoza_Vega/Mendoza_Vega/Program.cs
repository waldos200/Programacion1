using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza_Vega
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i = 0;
            int par = 0;
            int impar = 0;
            string numerospares = "", numerosimpares = "";


            // Se piden los numeros 
            for (i = 0; i <= 9; i++)
            {
                try
                {
                    Console.Write("Ingrese el numero {0}: ", (i + 1));
                    num[i] = Convert.ToInt32(Console.ReadLine());

                    //evalua si es par o impar    
                    if (num[i] % 2 == 0)
                    {
                        par = par + num[i];
                        numerospares = numerospares + num[i] + ", ";
                    }
                    else
                    {
                        impar = impar + num[i];
                        numerosimpares = numerosimpares + num[i] + ", ";
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error " + ex.Message);
                    i--;
                }
            }

            Console.WriteLine("\nEstos son los numeros pares: \n{0}", numerospares);
            Console.WriteLine("\nEstos son los numeros impares: \n{0}", numerosimpares);
            Console.WriteLine("\nEsta es la suma de los pares: " + par);
            Console.WriteLine("\nEsta es la suma de los impares: " + impar);
            Console.ReadKey();
        }
    }
}

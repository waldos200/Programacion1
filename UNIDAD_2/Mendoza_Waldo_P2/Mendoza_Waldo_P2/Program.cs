using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza_Waldo_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, contMen = 0, conTol = 0;
            double prom = 0, num, sum = 0;

            try
            {
                Console.Write("digite un numero diferente de 0: ");
                num = Convert.ToInt32(Console.ReadLine());
                while (num != 0)
                {
                    if (num > 25)
                    {
                        cont++;
                    }
                    if (num < 0)
                    {
                        contMen++;
                    }
                    if (num > 0)
                    {
                        conTol++;
                        sum = sum + num;
                        prom = sum / conTol;
                    }
                    Console.Write("digite un numero diferente de 0: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n\nCantidad de numeros mayores que 25 leidos son: " + cont);
                Console.WriteLine("\n\nCantidad de numeros negativos leidos son: " + contMen);
                Console.WriteLine("\n\nEste es el promedio de los numeros: " + prom);
            } 
            catch(FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}

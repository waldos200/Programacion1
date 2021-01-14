using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImparCero_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;

            for (i = 1; i <= 3; i++)
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num == 0)
                        Console.WriteLine("El numero es cero");
                    else if (num % 2 == 0)
                        Console.WriteLine("El numero es par");
                    else
                        Console.WriteLine("El numero es impar");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error!!, " + ex.Message);
                    i--;
                }
            }
            Console.ReadKey();
        }
    }
}

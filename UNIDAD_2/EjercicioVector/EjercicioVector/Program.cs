using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioVector
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sueldos = new double[5];
            int i;

            for (i = 0; i <= 4; i++)
            {
                try
                {
                    Console.Write("Ingrese sueldo del empleado {0}: ", (i + 1));
                    sueldos[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("error " + ex.Message);
                    i--;
                }
            }
            // Imprimr arreglo
            Console.WriteLine("\nLos sueldos son: ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
            Console.ReadKey();
        }
    }
}

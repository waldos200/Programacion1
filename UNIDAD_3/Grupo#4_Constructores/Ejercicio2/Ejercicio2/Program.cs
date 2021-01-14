using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            KilosLibras obj = new KilosLibras();
            try
            {
                Console.Write("\nDigite los kilos que quiere pasar a libras: ");
                obj.numero = Convert.ToDouble(Console.ReadLine());
                while (obj.numero > 0)
                {
                    Console.WriteLine("Esta es la conversion de kilos a libras: " + obj.Conversor(obj.numero) + " lb");
                    Console.Write("\nDigite los kilos que quiere pasar a libras: ");
                    obj.numero = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Error dato no valido");
            }
            Console.ReadKey();
        }
    }
}

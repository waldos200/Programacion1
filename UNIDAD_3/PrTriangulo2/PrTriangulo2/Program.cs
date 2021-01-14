using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrTriangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            try
            {
                Console.Write("Digite la base: ");
                t1.Base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite la altura: ");
                t1.Altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("El area del triangulo es: " + t1.CalculoArea(t1.Base, t1.Altura));
                Console.WriteLine("Base: " + t1.Base + "\nAltura: " + t1.Altura);
            }
            catch
            {
                Console.WriteLine("Error!! datos no válidos");
            }

            Console.ReadKey();
        }
    }
}

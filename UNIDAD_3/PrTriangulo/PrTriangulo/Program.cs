using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();

            t1.Captura();
            Console.WriteLine("Base: " + t1.Base + "\nAltura: " + t1.Altura);
            Console.WriteLine("El area del triangulo es: " + t1.Area(t1.Base, t1.Altura));

            Console.ReadKey();
        }
    }
}

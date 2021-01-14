using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNueva
{
    class Program
    {
        static void Main(string[] args)
        {
            Productos producto1 = new Productos();

            producto1.guardarV();
            producto1.guardarP();

            producto1.imprimirV();
            Console.WriteLine("");
            producto1.imprimirP();
            Console.ReadKey();
        }
    }
}

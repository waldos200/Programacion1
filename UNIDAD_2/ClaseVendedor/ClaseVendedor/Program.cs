using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor v1 = new Vendedor();
            v1.Captura();
            Console.ReadKey();
        }
    }
}

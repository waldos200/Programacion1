using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescSuper
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            Supermercado s1 = new Supermercado();

            Console.Write("Desea ver de cuanto sera su descuento S/N : ");
            resp = Console.ReadLine().ToLower();
            while (resp == "s")
            {
                s1.Captura();
                Console.Write("\nDesea ver de cuanto sera su descuento S/N: ");
                resp = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}

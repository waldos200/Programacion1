using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            Almacen s1 = new Almacen();

            Console.Write("Desea ingresar datos? S/N : ");
            resp = Console.ReadLine().ToLower();
            while (resp == "s")
            {
                s1.Captura();
                Console.Write("\nDesea Seguir S/N: ");
                resp = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pais, moneda;

            Console.WriteLine("\n\n\tBIENVENIDO AL PROGRAMA RELACION PAIS-MONEDA");
            Console.WriteLine("\n\tInfo: \'Recuerde que los paises son nombres propios.\'");

            Console.Write("\n\n\tIngrese el nombre del pais: ");
            pais = Console.ReadLine();
            Console.Write("\n\tIngrese la moneda de ese pais: ");
            moneda = Console.ReadLine();

            Monedas m1 = new Monedas(pais, moneda);
            Console.ReadKey();
        }
    }
}

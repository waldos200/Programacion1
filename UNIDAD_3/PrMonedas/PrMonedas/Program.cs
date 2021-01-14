using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrMonedas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables auxiliares
            string pais, moneda;

            // capturando datos
            Console.Write("Digite el nombre del pais: ");
            pais = Console.ReadLine();
            Console.Write("Digite la moneda: ");
            moneda = Console.ReadLine();

            // Creando el objeto del constructor personalzado 
            Monedas m1 = new Monedas(pais, moneda);
            Console.ReadKey();
        }
    }
}

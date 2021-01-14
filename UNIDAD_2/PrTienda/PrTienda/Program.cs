using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrTienda
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            double total_compra, total_vendido = 0;
            int clientes = 0;

            Console.Write("Desea ingresar datos s/n: ");
            resp = Console.ReadLine().ToLower();
            while (resp == "s")
            {
                try
                {
                    Console.Write("Ingrese el total de la compra: ");
                    total_compra = Convert.ToDouble(Console.ReadLine());
                    total_vendido = total_vendido + total_compra;
                    clientes++;
                    Console.Write("Desea continuar s/n: ");
                    resp = Console.ReadLine().ToLower();
                }
                catch (Exception)
                {
                    Console.WriteLine("Error, datos incorrectos");
                }
            }
            Console.WriteLine("El total vendido fue de: $" + total_vendido);
            Console.WriteLine("La cantidad de clientes atendida fue de: " + clientes);
            Console.ReadKey();
        }
    }
}

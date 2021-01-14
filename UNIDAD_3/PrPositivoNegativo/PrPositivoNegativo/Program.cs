using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrPositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros obj1 = new Numeros();

            Console.Write("Desea introducir un numero s/n: ");
            string resp = Console.ReadLine().ToLower();
            while (resp == "s")
            {
                try
                {
                    Console.Write("Digite un numero: ");
                    obj1.Numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(obj1.Comprobar(obj1.Numero));
                }
                catch
                {
                    Console.WriteLine("Error, dato incorrecto");
                }

                Console.Write("Desea continuar s/n: ");
                resp = Console.ReadLine().ToLower();
                Console.ReadKey();
            }
        }
    }
}

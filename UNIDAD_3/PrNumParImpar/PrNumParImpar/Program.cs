using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrNumParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros obj1 = new Numeros();
            Numeros obj2 = new Numeros();

            try
            {
                // Capturando la variable con el objeto 1
                Console.Write("Digite un numero: ");
                obj1.Numero = Convert.ToInt32(Console.ReadLine());

                // Invocando el método con el objeto 1
                Console.WriteLine(obj1.Comprobar(obj1.Numero));

                // Capturando la variable co el objeto 2
                Console.Write("\nDigite un numero: ");
                obj2.Numero = Convert.ToInt32(Console.ReadLine());

                // Invocando el método con el objeto 2
                Console.WriteLine(obj2.Comprobar(obj2.Numero));
            }
            catch (Exception)
            {
                Console.WriteLine("Error! dato no valido");
            }
            Console.ReadKey();
        }
    }
}

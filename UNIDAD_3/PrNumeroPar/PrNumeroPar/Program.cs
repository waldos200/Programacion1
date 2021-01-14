using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrNumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            ParImpar obj = new ParImpar();
            while (resp.ToLower() == "s")
            {
                // Capturando el valor de la variable
                try
                {
                    Console.Write("Digite un numero: ");
                    obj.Numero = Convert.ToInt32(Console.ReadLine());
                    // Invocando al método
                    // Se hace através de la instrucción Console porque el método retorna valor
                    Console.WriteLine(obj.Comprobar(obj.Numero));
                }
                catch
                {
                    Console.WriteLine("Error dato no válido!!");
                }
                Console.Write("Desea continuar s/n: ");
                resp = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

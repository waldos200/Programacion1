using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capturando datos para pasarlos como argumentos al constructor
            // Se declaran variables auxiliares
            int n1, n2;
            try
            {
                Console.Write("Digite un numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite otro numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());

                // Creado el objeto
                Suma s1 = new Suma(n1, n2);

                // Invocando al método
                Console.WriteLine("La suma es: " + s1.Sumar());
            }
            catch
            {
                Console.WriteLine("Error datos no válidos");
            }
            Console.ReadKey();
        }
    }
}

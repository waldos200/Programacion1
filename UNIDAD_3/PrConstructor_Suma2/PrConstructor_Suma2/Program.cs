using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Suma2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creando un obeto y pasandole como arrgumentos los valores de 0

            Suma s1 = new Suma(0, 0);

            // Invocando al método de captura
            s1.Captura();

            // Creando otro objeto para pasarle como argumentos los valores capturados
            Suma s2 = new Suma(s1.num1, s1.num2);

            // Invocando al método con el segundo objetivo
            Console.WriteLine("La suma es: " + s2.Sumar());

            Console.ReadKey();
        }
    }
}

using System;

namespace Ejercicio4
{
    class LongitudCirculo
    {
        static void Main(string[] args)
        {
            double superficie, longitud, radioS, radioL;

            Console.Write("Digite el radio para la superficie: ");
            radioS = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite el radio para la Longitud: ");
            radioL = Convert.ToDouble(Console.ReadLine());

            superficie = 3.1416 * Math.Pow(radioS, 2);
            longitud = 2 * 3.1416 * radioL;

            Console.WriteLine("\nEste es el resultado: \n===============================");
            Console.WriteLine("\nEste es el resultado de supericie: " + superficie);
            Console.WriteLine("\nEste es el resultado de longitud: " + longitud);
        }
    }
}

using System;

namespace ejercicio2
{
    class PruebaDivi
    {
        static void Main(string[] args)
        {
            // Declarando las variables de tipo double
            double num1, num2, divi;

            // Capturando los datos
            Console.Write("Digite un numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite otro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Convirtiendo a entero el resultado de la division
            divi = (int)(num1 / num2);

            // Mostrando el resultado de la division
            Console.WriteLine("La division es: " + divi);
        }
    }
}

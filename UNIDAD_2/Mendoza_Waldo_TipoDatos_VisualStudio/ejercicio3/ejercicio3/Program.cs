using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares, colones;

            Console.WriteLine("Digite la cantidad de dolares que quiere cambiar a colones: ");
            dolares = Convert.ToDouble(Console.ReadLine());

            colones = dolares / 0.1142;

            Console.WriteLine("esta es la conversion de {0:C2} dolares a colones {1:C2}", dolares, colones);
        }
    }
}

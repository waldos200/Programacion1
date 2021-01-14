using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, costoXChicle ;
            int chicle = 20;

            Console.WriteLine("Digite el precio de los chicles que compro en el supermercado: ");
            precio = Convert.ToDouble(Console.ReadLine());

            costoXChicle = precio / chicle;

            Console.WriteLine("El precio por chicle es: {0:C2}", costoXChicle);
        }
    }
}

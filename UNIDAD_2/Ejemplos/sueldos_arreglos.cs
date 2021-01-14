using System;
class Sueldos_arreglo
{
    static void Main()
    {
        // Declarando arreglo
        double[] sueldos = new double[5];
        int i;

        for (i = 0; i <= 4; i++)
        {
            try
            { // llenamos el arreglo con sueldos
                Console.Write("Ingrese el sueldo {0}: ", (i + 1));
                sueldos[i] = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
                // No se incremente el contador cuando haya error
                i--;
            }
        }
        // Imprimiendo el arreglo
        Console.WriteLine("\nLos sueldos son los siguientes: ");
        for (i = 0; i <= 4; i++)
        {
            Console.WriteLine(sueldos[i]);
        }
    }
}
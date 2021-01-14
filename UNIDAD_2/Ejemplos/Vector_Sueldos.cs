using System;
class Vector_Sueldos
{
    static void Main()
    {
        double[] sueldos = new double[5];
        int i;

        for (i = 0; i <= 4; i++)
        {
            try
            {
                Console.Write("Ingrese el sueldo {0}: ", (i + 1));
                sueldos[i] = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
                i--;
            }
        }
        double mayor = sueldos[0];
        double menor = sueldos[0];
        for (i = 0; i <= 4; i++)
        {
            if (sueldos[i] > mayor)
            {
                mayor = sueldos[i];
            }
            else if (sueldos[i] < menor)
            {
                menor = sueldos[i];
            }
        }
        Console.WriteLine("\n Los sueldos son los siguientes: ");
        for (i = 0; i <= 4; i++)
        {
            Console.WriteLine(sueldos[i]);
        }
        Console.WriteLine("\nEl sueldo menor es: " + menor);
        Console.WriteLine("\nEl sueldo mayor es: " + mayor);
    }
}
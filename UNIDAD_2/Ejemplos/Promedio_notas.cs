using System;
class Promedio_notas
{
    static void Main(string[] args)
    {
        double[] notas = new double[30];
        int i;
        double suma = 0, promedio = 0;
        for (i = 0; i <= 30; i++)
        {
            try
            {
                Console.Write("Ingrese la nota {0}: ", (i + 1));
                notas[i] = Convert.ToDouble(Console.ReadLine());
                suma += notas[i]; // Acumulador de las notas
            }
            catch (Exception)
            {
                Console.WriteLine("Error!! tipo de dato incorrecto");
                i--;
            }
        }
        Console.WriteLine("\nLas notas son los siguientes: ");
        for (i = 0; i <= 30; i++)
        {
            Console.WriteLine(notas[i]);
        }
        promedio = suma / 30;
        Console.WriteLine("\nEl promedio es: " + promedio);
    }
}
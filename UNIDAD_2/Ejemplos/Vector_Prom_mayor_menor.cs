using System;
namespace Vector_Prom_mayor_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            double promedio;
            int i, N, menor = 0, mayor = 0;
            try
            {
                Console.Write("Ingrese la cantidad de numeros a almacenar: ");
                N = Convert.ToInt32(Console.ReadLine());
                double[] numeros = new double[N];
                for (i = 0; i < N; i++)
                {
                    try
                    {
                        Console.Write("Ingrese un numero: ");
                        numeros[i] = Convert.ToDouble(Console.ReadLine());
                        suma += numeros[i]; // Acumulador para el promedio
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error!! tipo de datos incorrectos");
                        i--;
                    }
                }
                promedio = suma / N;

                for (i = 0; i < N; i++)
                {
                    // Para saber las longitudes de los nuevos numeros arreglos
                    if (numeros[i] > promedio)
                    {
                        mayor++; // Longitud para los mayores
                    }
                    else if (numeros[i] < promedio)
                    {
                        menor++; // Longitud para los menores
                    }
                }
                // Declaremos los nuevos vectores con sus respectivas longitudes
                double[] Vector_mayor = new double[mayor];
                double[] Vector_menor = new double[menor];

                int j = 0, k = 0; // Se necesita 2 indices para los nuevos vectores

                for (i = 0; i < N; i++)
                {
                    if (numeros[i] > promedio)
                    {
                        Vector_mayor[j] = numeros[i]; // Almaceno el valor en el vector mayor
                        j++;
                    }
                    else if (numeros[i] < promedio)
                    {
                        Vector_menor[k] = numeros[i]; // Almacene el valor en el vector menor
                        k++;
                    }
                }
                // Imprimimos los 3 vectores por separado 
                Console.WriteLine("\nVector original:");
                for (i = 0; i < N; i++)
                {
                    Console.Write(numeros[i] + ", ");
                }
                Console.WriteLine("\n\nEl promedio es: " + promedio);

                Console.WriteLine("\nVector mayor que el promedio: ");
                for (i = 0; i < mayor; i++)
                {
                    Console.Write(Vector_mayor[i] + ", ");
                }
                Console.WriteLine("\nVector menos promedio: ");
                for (i = 0; i < menor; i++)
                {
                    Console.Write(Vector_menor[i] + ", ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
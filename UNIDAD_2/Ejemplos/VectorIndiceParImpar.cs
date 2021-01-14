using System;
namespace VectorIndiceParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, suma_par = 0, suma_impar = 0;
            Console.Write("Ingrese la cantidad de numeros a almacenar: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[n];
            for (i = 0; i < n; i++)
            {
                try
                {
                    Console.Write("Ingrese un numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        suma_par = suma_par + numeros[i];
                    }
                    else
                    {
                        suma_impar = suma_impar + numeros[i];
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error!! dato incorrecto");
                    i--;
                }
            }
            Console.WriteLine("\nValores del arreglo: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(numeros[i] + ", ");
            }
            Console.WriteLine("\nSuma de indices pares: " + suma_par);
            Console.WriteLine("\nSuma de indices impares: " + suma_impar);
            Console.ReadKey();
        }
    }
}
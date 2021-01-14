using System;
namespace VectorInvertido
{
    class program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int[] inverso = new int[5];
            int i;

            for (i = 0; i <= 4; i++)
            {
                try
                {
                    Console.Write("Ingrese un numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error !! tipo de dato incorrecto");
                    i--;
                }
            }

            int j = 0; // Inicializando un segundo indice
            for (i = 4; i >= 0; i--)
            {
                inverso[j] = numeros[i]; // Asignando el arreglo origial al nuevo
                j++; // Decrementamos el indice
            }
            Console.WriteLine("\nVector original");
            for (i = 0; i <= 4; i++)
            {
                Console.Write(numeros[i] + ", ");
            }
            Console.WriteLine("\n\nVector invertido");
            for (i=0; i <= 4; i++)
            {
                Console.Write(inverso[i] + ", ");
            }
            Console.ReadKey();
        }
    }
}
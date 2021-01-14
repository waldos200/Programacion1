/* Hacer un programa que imprima el cubo y la raíz cuadrada de un numero
ingresado por teclado; el programa debe estar desarrollado de tal manera
que el proceso a efectuarse sea repetitivo. Debe terminar cuando el usuario
ya no desea continuar. */

using System;
class Ejercicio5
{
    static void Main(string[] args)
    {
        int respuesta;
        double numero, res, resp;

        Console.WriteLine("Desea ingresar un numero para saber su cubo y su raiz cuadrada \n1. Si \n2. No ");
        Console.Write("Digite una opcion: ");

        try
        {
            respuesta = Convert.ToInt32(Console.ReadLine());
            while (respuesta != 2)
            {
                switch (respuesta)
                {
                    case 1:
                        try
                        {
                            Console.Write("Digite un numero: ");
                            numero = Convert.ToInt32(Console.ReadLine());
                            res = Math.Pow(numero, 3);
                            resp = Math.Sqrt(numero);
                            Console.WriteLine("El numero que usted digito es el {0}, el cubo de ese numero es {1} y la raiz cuadrada es {2:F2} ", numero, res, resp);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Error" + ex.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion no existente");
                        break;
                }
                Console.WriteLine("Desea ingresar un numero para saber su cubo y su raiz cuadrada \n1. Si \n2. No ");
                Console.Write("Digite una opcion: ");
                respuesta = Convert.ToInt32(Console.ReadLine());
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error " + ex.Message + ", intente con un numero");
        }
        Console.WriteLine("Nos vemos hasta la proxima");
    }
}
using System;

namespace ejercicio
{
    class suma
    {
        static void Main(string[] args)
        {
            // declaracion de variable de tipo int
            int num1, num2, suma;
            // captura de datos desde teclado
            // convirtiendo la captura a dato int
            Console.Write("Digit el prime numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            // sumando los dos valores 
            suma=num1+num2;
            // imprimiendo el resultado aplicando formato
            Console.WriteLine("La suma es: {0} ",suma);
            // Tambien se puede imprimir sn formato
            Console.WriteLine("La suma es: " + suma);
        }
    }
}

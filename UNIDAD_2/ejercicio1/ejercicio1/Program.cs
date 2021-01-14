using System;

namespace CapturarDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarando variables
            string nombre, apellido;
            int edad;

            // Capturar datos
            Console.Write("Digite el nombre: ");
            nombre = Console.ReadLine(); // no es necesario conversion por ser string
            Console.Write("Digite el apellido: ");
            apellido = Console.ReadLine(); // no es necesario conversion por ser string
            Console.Write("Digite la edad: ");
            edad = Convert.ToInt32(Console.ReadLine()); // convirtiendo la captura(string) a int

            // Mostrando los datos en pantalla
            Console.WriteLine("\nDatos de la persona: \n=================================");
            Console.WriteLine("Nombre: " + nombre + "\nApellido: " + apellido + "\nEdad: " + edad);
        }
    }
}

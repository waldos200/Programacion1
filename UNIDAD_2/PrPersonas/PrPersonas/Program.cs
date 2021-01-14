using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrPersonas
{
    class Persona
    {
        // atributos de la clase persona
        public string nombre, genero;
        public int edad;
    }
}

namespace PrPersonas
{
    class Program
    {
        static void Main(String[] args)
        {
            // Creando 2 objetos de la clase persona
            Persona p1 = new Persona();
            Persona p2 = new Persona();

            // Capturando datos con el objeto 1 (p1)
            Console.Write("Digite el nombre: ");
            p1.nombre = Console.ReadLine();
            Console.Write("Digite el genero: ");
            p1.genero = Console.ReadLine();
            Console.Write("Digite la edad: ");
            p1.edad = Convert.ToInt32(Console.ReadLine());

            // Imprimiendo la informacion con el objeto 1 (p1)
            Console.WriteLine("\nNombre: " + p1.nombre + "\nGenero: " + p1.genero + "\nEdad: " + p1.edad);

            // Capturando datos con el objeto 2 (p2)
            Console.Write("\nDigite el nombre: ");
            p2.nombre = Console.ReadLine();
            Console.Write("Digite el genero: ");
            p2.genero = Console.ReadLine();
            Console.Write("Digite la edad: ");
            p2.edad = Convert.ToInt32(Console.ReadLine());

            // Imprimiendo la informacion con el objeto 2 (p2)
            Console.WriteLine("\nNombre: " + p2.nombre + "\nGenero: " + p2.genero + "\nEdad: " + p2.edad);

            Console.ReadLine();
        }
    }
}

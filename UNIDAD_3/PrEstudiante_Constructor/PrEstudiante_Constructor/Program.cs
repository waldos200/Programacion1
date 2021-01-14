using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiante_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea un objeto del constructor por omision
            Estudiante e1 = new Estudiante();

            // Captura de datos
            Console.Write("Digite el carnet: ");
            e1.carnet = Console.ReadLine();
            Console.Write("Digite el nombre: ");
            e1.nombre = Console.ReadLine();
            Console.Write("Digite el apellido: ");
            e1.apellido = Console.ReadLine();
            try
            {
                Console.Write("Digite la nota 1: ");
                e1.N1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite la nota 2: ");
                e1.N2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite la nota 3: ");
                e1.N3 = Convert.ToDouble(Console.ReadLine());
                e1.MostrarDatos();
            }
            catch
            {
                Console.WriteLine("Error, datos no válidos");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiante_Constructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* No se puede crear un objeto del constructor por omision porque no hay uno en la clase,
            el unico que existe es uno con parámetros, por lo tanto, procederemos a crear variables
            auxiliares para enviarselas como argumentos al constructor personalizado.
            Estudiante e1 = new Estudiante()
            */

            // Variables auxiliares
            string carnet, nombre, apellido;
            double n1, n2, n3;

            // Captura de datos
            Console.Write("Digite el carnet: ");
            carnet = Console.ReadLine();
            Console.Write("Digite el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Digite el apellido: ");
            apellido = Console.ReadLine();
            try
            {
                Console.Write("Digite la nota 1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite la nota 2: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite la nota 3: ");
                n3 = Convert.ToDouble(Console.ReadLine());
                Estudiante e1 = new Estudiante(carnet, nombre, apellido, n1, n2, n3);
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

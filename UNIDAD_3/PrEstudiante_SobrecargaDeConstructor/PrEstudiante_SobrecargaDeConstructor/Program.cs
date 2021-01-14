using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiante_SobrecargaDeConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 2; i++)
            {
                try
                {
                    Estudiante e1 = new Estudiante();

                    // Captura de datos
                    Console.Write("Digite el carnet: ");
                    e1.carnet = Console.ReadLine();
                    Console.Write("Digite el nombre: ");
                    e1.nombre = Console.ReadLine();
                    Console.Write("Digite el apellido: ");
                    e1.apellido = Console.ReadLine();
                    Console.Write("Digite la nota 1: ");
                    e1.N1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite la nota 3: ");
                    e1.N2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite la nota 2: ");
                    e1.N3 = Convert.ToDouble(Console.ReadLine());
                    // Creando el segundo objeto con el constructor con parámetros
                    Estudiante e2 = new Estudiante(e1.carnet, e1.nombre, e1.apellido, e1.N1, e1.N2, e1.N3);
                    // El método MostrarDatos ya no se invoca porque lo hace el constructor personalizado
                }
                catch
                {
                    Console.WriteLine("Error, datos no válidos");
                }
            }
            Console.ReadKey();
        }
    }
}

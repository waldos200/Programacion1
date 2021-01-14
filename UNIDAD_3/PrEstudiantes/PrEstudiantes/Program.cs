using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Estudiante e1 = new Estudiante();
                //capturando datos
                Console.Write("\nDigite el carnet del estudiante {0}: ", i);
                e1.carnet = Console.ReadLine();
                Console.Write("Digite el nombre: ");
                e1.nombre = Console.ReadLine();
                Console.Write("Digite el apellido: ");
                e1.apellido = Console.ReadLine();

                try
                {
                    Console.Write("Digite la nota 1: ");
                    e1.n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite la nota 2: ");
                    e1.n2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite la nota 3: ");
                    e1.n3 = Convert.ToDouble(Console.ReadLine());

                    Estudiante e2 = new Estudiante(e1.carnet, e1.nombre, e1.apellido, e1.n1, e1.n2, e1.n3);

                    e2.Mostrar();
                }
                catch (Exception ex)
                {
                    i--; // Se resta el valor del contador cuando el dato es erroneo
                    Console.WriteLine("Error, datos no validos" + ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}

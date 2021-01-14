using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cocinero m1 = new Cocinero();

            try
            {
                Console.Write("\n\n\tIngrese el nombre del cocinero: ");
                m1.Nombre = Console.ReadLine();
                Console.Write("\n\tIngrese la especialidad del cocinero: ");
                m1.Especialidad = Console.ReadLine();
                Console.Write("\n\tIngrese la edad del cocinero: ");
                m1.Edad = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error, datos no validos");
            }
            m1.MostrarDatos(m1.Nombre, m1.Especialidad, m1.Edad);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, genero, carne;
            int edad, cant_mat;
            double nota1, nota2, nota3;

            Console.WriteLine("\t** Ingrese los Datos del Alumno **");
            Console.WriteLine("\t** ============================ **");


            Console.Write("\tNombre    : ");
            nombre= Console.ReadLine();
            Console.Write("\tGenero    : ");
            genero = Console.ReadLine();
            Console.Write("\tEdad      : ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("\tNo. Carne : ");
            carne = Console.ReadLine();
            Console.Write("\tNota 1    : ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tNota 2    : ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tNota 3    : ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tCant. Mat : ");
            cant_mat = Convert.ToInt32(Console.ReadLine());

            Alumno a1 = new Alumno(nombre, genero, edad, carne, nota1, nota2, nota3, cant_mat);
            a1.Mostrar();
            Console.Write("\n\tEl promedio es : {0}", Convert.ToDouble(a1.Promedio()));
            Console.ReadKey();

        }
    }
}

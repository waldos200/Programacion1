using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Estudiante
    {
        public string carnet, nombre, apellido;
        public double nota1, nota2, nota3, nota4, nota5;
        public void Captura()
        {
            Console.Write("Digite el carnet: ");
            carnet = Console.ReadLine();
            Console.Write("Digite el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Digite el apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Digite la nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite la nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite la nota 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite la nota 4: ");
            nota4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite la nota 5: ");
            nota5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nCarnet: " + carnet + "\nNombre: " + nombre + " " + apellido);
            Console.WriteLine("El promedio es: " + CalculoPromedio() + "\n");
        }
        public double CalculoPromedio()
        {
            return (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
        }
    }
}

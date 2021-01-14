using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasDosD_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();

            // Capturando datos
            Console.WriteLine("Digite el ancho: ");
            t1.Anchura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el alto: ");
            t1.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el estilo del triangulo: ");
            t1.estilo = Console.ReadLine();

            // Invocando metodos
            Console.WriteLine("Informacion para t1: ");
            t1.MostrarEstilo();
            t1.MostrarDim();
            Console.WriteLine("El area es " + t1.Area());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

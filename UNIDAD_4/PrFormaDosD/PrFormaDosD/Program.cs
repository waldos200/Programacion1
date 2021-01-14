using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrFormaDosD
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo();
            t1.ancho = 4.0;
            t1.alto = 4.0;
            t1.estilo = "isosceles";
            t2.ancho = 8.0;
            t2.alto = 12.0;
            t2.estilo = "rectangulo";
            Console.WriteLine("Informacion para t1: ");
            t1.MostrarEstilo();
            t1.MostrarDim();
            Console.WriteLine("El area es " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Informacion para t2: ");
            t2.MostrarEstilo();
            t2.MostrarDim();
            Console.WriteLine("El area es " + t2.Area());
            Console.ReadKey();
        }
    }
}

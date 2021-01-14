using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo();
            Triangulo t2 = new Triangulo("rectangulo", 8.0, 12.0);
            Triangulo t3 = new Triangulo(4.0);
            t1 = t2;
            Console.WriteLine("Inormacion para t1: ");
            t1.MostrarEstilo();
            t1.MostrarDim();
            Console.WriteLine("El area es " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Inormacion para t2: ");
            t2.MostrarEstilo();
            t2.MostrarDim();
            Console.WriteLine("El area es " + t2.Area());
            Console.WriteLine();
            Console.WriteLine("Inormacion para t3: ");
            t3.MostrarEstilo();
            t3.MostrarDim();
            Console.WriteLine("El area es " + t3.Area());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

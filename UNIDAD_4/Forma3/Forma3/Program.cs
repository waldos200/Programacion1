using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo("isosceles", 4.0, 4.0);
            Triangulo t2 = new Triangulo("right", 8.0, 12.0);
            Console.WriteLine("Informacion para t1: ");
            t1.MostrarEstilo();
            t1.MostrarDim();
            Console.WriteLine("El area es " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Informacion para t2: ");
            t2.MostrarEstilo();
            t2.MostrarDim();
            Console.WriteLine("El area es: " + t2.Area());
            Console.ReadKey();
        }
    }
}

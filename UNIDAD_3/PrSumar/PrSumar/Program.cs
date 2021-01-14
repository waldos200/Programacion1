using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrSumar
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumar s1 = new Sumar();
            s1.Captura();
            // Invocando el método y pasandoles como argumentos las propiedades
            s1.Suma(s1.Num1, s1.Num2);
            Console.ReadKey();
        }
    }
}

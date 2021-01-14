using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;

            Console.WriteLine("\n\n\t\tBIENVENIDO AL PROGRAMA DE MULTIPLICACIONES");
            Console.WriteLine("\n\t\tInfo: \'Recuerde la propiedad conmutativa de la multiplicacion.\'");

            Console.Write("\n\n\t\tIngrese el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\t\tIngrese el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());


            Multiplicacion obj1 = new Multiplicacion(numero1, numero2);
            obj1.Producto(numero1, numero2);
            Console.ReadKey();
        }
    }
}

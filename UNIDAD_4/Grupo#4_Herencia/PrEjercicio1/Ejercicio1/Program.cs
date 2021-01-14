using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil obj = new Automovil("Nissan", "negro", 2019);
            Sedan obj1 = new Sedan("Toyota", "azul", 2019, "Corola", 4);
            Camioneta obj2 = new Camioneta("Mazda", "blanco", 2019, "v6", "Diesel");

            obj.Mostrar();
            Console.WriteLine();
            Console.WriteLine("Sedan");
            obj1.Mostrar();
            Console.WriteLine();
            Console.WriteLine("Camioneta");
            obj2.Mostrar();

            Console.ReadKey();
        }
    }
}

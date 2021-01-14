using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro obj1 = new Perro();

            Console.Write("Digite el color del perro: ");
            obj1.color = Console.ReadLine();
            Console.Write("Digite el sexo del perro: ");
            obj1.sexo = Console.ReadLine();
            Console.Write("Digite la raza del perro: ");
            obj1.raza = Console.ReadLine();
            Console.Write("Digite la edad del perro en años: ");
            obj1.edad = Convert.ToInt32(Console.ReadLine());

            obj1.Mostrar();

            Gato obj2 = new Gato();

            Console.Write("Digite el color del gato: ");
            obj2.color = Console.ReadLine();
            Console.Write("Digite el sexo del gato: ");
            obj2.sexo = Console.ReadLine();
            Console.Write("Digite el nombre del gato: ");
            obj2.nombre = Console.ReadLine();

            obj2.Mostrar();

            Console.ReadKey();
        }
    }
}
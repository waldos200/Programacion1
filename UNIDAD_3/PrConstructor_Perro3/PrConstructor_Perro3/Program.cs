using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Perro3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mascota m1 = new Mascota("perro", "Flipper", "macho", "2 años"); // Pasandole argumento al constructor
            Console.ReadKey();
        }
    }
}

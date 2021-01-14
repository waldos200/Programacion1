using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio5
{
    class Mascotas
    {
        public string color, sexo;
        public Mascotas()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("\t\t\tMis mascotas");
        }

        public void Mostrar()
        {
            Console.WriteLine("Su color es: " + color);
            Console.WriteLine("Su sexo es: " + sexo);
            Console.WriteLine("========================================================");
        }
    }
}

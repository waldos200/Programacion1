using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m1 = new Metodos();

            // Invocando el método y enviando argumentos
            m1.Datos("Juan", "Perez");
            Console.ReadKey();
        }
    }
}

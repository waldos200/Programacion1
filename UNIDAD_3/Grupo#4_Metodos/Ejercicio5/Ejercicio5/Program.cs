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
            Numeros n1 = new Numeros();
            n1.Captura();
            n1.Calculos();
            n1.Resultados();
            Console.ReadKey();
        }
    }
}

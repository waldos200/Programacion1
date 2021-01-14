using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante();
            for (int i = 1; i <= 2; i++)
            {
                e1.Captura();
                Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}

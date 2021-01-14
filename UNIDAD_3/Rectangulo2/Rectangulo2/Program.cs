using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo2
{
    class UsaRect
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 9);

            Console.WriteLine("Área de r1: " + r1.Area());
            Console.WriteLine("Área de r2: " + r2.Area());

            Console.ReadKey();
        }
    }
}

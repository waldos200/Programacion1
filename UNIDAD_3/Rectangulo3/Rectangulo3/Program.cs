using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo3
{
    class UsaRect
    {
        static void Main(string[] args)
        {
            Rect r1 = new Rect(4, 5);
            Rect r2 = new Rect(7, 5);
            Console.WriteLine("El area de r1 es: " + r1.Area());
            Console.WriteLine("El area de r2 es: " + r2.Area());

            Console.ReadKey();
        }
    }
}

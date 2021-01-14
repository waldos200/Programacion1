using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructores obj1 = new Constructores();
            Constructores obj2 = new Constructores(10);
            Constructores obj3 = new Constructores(5.4);
            Constructores obj4 = new Constructores("Hola");

            Console.ReadKey();
        }
    }
}

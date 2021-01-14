using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma s1 = new Suma();
            s1.Operar();
            Resta r1 = new Resta();
            r1.Operar();
            Console.ReadKey();
        }
    }
}

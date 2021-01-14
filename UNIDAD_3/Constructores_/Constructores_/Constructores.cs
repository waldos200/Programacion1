using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_
{
    class Constructores
    {
        public Constructores()
        {
            Console.WriteLine("Constructor sin parametros");
        }

        public Constructores(int x)
        {
            Console.WriteLine("Cosntructor con un parametro entero: " + x);
        }
        public Constructores(double x)
        {
            Console.WriteLine("Constructor con un parametro double: " + x);
        }
        public Constructores(String x)
        {
            Console.WriteLine("Constructor con un parametro String: " + x);
        }
    }
}

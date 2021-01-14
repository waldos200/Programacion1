using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Multiplicacion
    {
        public double numero1;
        public double numero2;

        public Multiplicacion(double n1, double n2)
        {
            numero1 = n1;
            numero2 = n2;
        }

        public void Producto(double numero1, double numero2)
        {
            Console.Write("\n\n\t\tLos numeros a multiplicar son \"{0}\" y \"{1}\"", numero1, numero2);

            Console.WriteLine("\n\n\t\tSu producto es: {0}", numero1 * numero2);
        }
    }
}

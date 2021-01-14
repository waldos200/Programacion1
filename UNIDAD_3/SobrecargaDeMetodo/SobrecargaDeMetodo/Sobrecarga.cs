using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeMetodo
{
    class Sobrecarga
    {
        public void Metodos()
        {
            Console.WriteLine("Metodo sin parametros");
        }

        public void Metodos(int a)
        {
            Console.WriteLine("Metodo con un parametro: " + a);
        }

        public int Metodos(int a, int b)
        {
            Console.WriteLine("La suma del metodo con dos parametros enteros es: ");
            return a + b;
        }

        public void Metodos(double a, double b)
        {
            Console.WriteLine("La suma del método con dos parámetros double es: " + (a + b));
        }
    }
}

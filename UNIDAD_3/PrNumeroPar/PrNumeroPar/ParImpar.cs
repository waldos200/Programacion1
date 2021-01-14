using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrNumeroPar
{
    class ParImpar
    {
        private int num;

        public ParImpar() // Constructor
        {
            Console.WriteLine("Comprobando si un numero es par, impar o cero");
        }

        public string Comprobar(int n)
        {
            if (n == 0)
            {
                return "El numero es cero";
            } else if (n % 2 == 0)
            {
                return "El numero es par";
            } else
            {
                return "El nuero es impar";
            }
        }

        // Propiedades para la variable privada
        public int Numero
        {
            get { return num; }
            set { num = value; }
        }
    }
}

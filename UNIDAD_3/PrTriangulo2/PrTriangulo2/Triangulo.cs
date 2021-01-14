using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrTriangulo2
{
    class Triangulo
    {
        private double bas, altura;

        public double CalculoArea(double b, double a)
        {
            return b * a / 2;
        }

        // Creacion de propiedades para variables privadas
        public double Base
        {
            get
            {
                return bas;
            }
            set
            {
                if (value > 0)
                {
                    bas = value;
                }
                else
                    Console.WriteLine("Error no se permiten valores negativos o cero");
            }
        }

        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                if (value > 0)
                    altura = value;
                else
                    Console.WriteLine("Error no se permiten valores negativos o cero");
            }
        }
    }
}

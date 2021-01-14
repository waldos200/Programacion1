using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrTriangulo
{
    class Triangulo
    {
        private double bas, altura;

        public void Captura()
        {
            try
            {
                Console.Write("Digite la base: ");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite la altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error!! datos no válidos");
            }
        }

        public double Area(double b, double a)
        {
            return b * a / 2;
        }

        // Propiedades para las variables privadas
        public double Base
        {
            get { return bas; }
            set
            {
                if (value > 0)
                    bas = value;
                else
                    Console.WriteLine("Solo se permiten vaalores positivos");
            }
        }

        public double Altura
        {
            get { return altura; }
            set
            {
                if (value > 0)
                    altura = value;
                else
                    Console.WriteLine("Solo se permiten valores positivos");
            }
        }
    }
}

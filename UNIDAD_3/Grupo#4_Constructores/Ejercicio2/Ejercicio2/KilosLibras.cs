using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class KilosLibras
    {
        private double kilos;
        public KilosLibras()
        {
            Console.WriteLine("Conversión de kilogramos a libras");
        }

        public double Conversor(double pkilos)
        {
            return pkilos * 2.2;
        }

        public double numero
        {
            get { return kilos; }
            set { kilos = value; }
        }
    }
}

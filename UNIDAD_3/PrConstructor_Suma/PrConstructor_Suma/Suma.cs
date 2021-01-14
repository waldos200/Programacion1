using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Suma
{
    class Suma
    {
        public int num1, num2;

        // Constructor con parámetros
        public Suma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        // Método que retorna la suma
        public int Sumar()
        {
            return num1 + num2;
        }
    }
}

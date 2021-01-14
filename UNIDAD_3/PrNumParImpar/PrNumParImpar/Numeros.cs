using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrNumParImpar
{
    class Numeros
    {
        private int num;

        public string Comprobar(int num)
        {
            if (num == 0)
            {
                return "El numero es cero";
            } else if (num % 2 == 0)
            {
                return "El umero es par";
            } else
            {
                return "El numero es impar";
            }
        }

        public int Numero
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
    }
}

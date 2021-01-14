using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrPositivoNegativo
{
    class Numeros
    {
        private int num; // Variable privada

        // Metodo con un parámetro
        public string Comprobar(int n)
        {
            if (n == 0)
                return "El numero es cero";
            else if (n > 0)
                return "El numero es positivo";
            else
                return "El numero es negativo";
        }

        public int Numero
        {
            get { return num; }
            set { num = value; }
        }
    }
}

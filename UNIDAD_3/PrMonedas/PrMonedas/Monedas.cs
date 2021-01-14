using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrMonedas
{
    class Monedas
    {
        public string pais, moneda;

        public Monedas(string pais, string moneda)
        {
            this.pais = pais;
            this.moneda = moneda;
            Console.WriteLine("La moneda de curso legal de {0} es el {1}", pais, moneda);
        }
    }
}

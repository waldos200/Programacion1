using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio3
{
    class Monedas
    {
		private string pais;
		private string moneda;

		public Monedas(string pais, string moneda)
		{
			this.pais = pais;
			this.moneda = moneda;
			Console.WriteLine("\n\n\tLa moneda de curso legal de {0} es el {1}", pais, moneda);
		}
		public string P
		{
			get { return pais; }
			set { pais = value; }
		}
		public string M
		{
			get { return moneda; }
			set { moneda = value; }
		}
	}
}

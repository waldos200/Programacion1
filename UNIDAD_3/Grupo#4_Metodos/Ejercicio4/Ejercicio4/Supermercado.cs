using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Supermercado
    {
        private int numero;
        private double totalDesc;
        double desc, total;

        public void Captura()
        {
            try
            {
                Console.Write("Cual fue el numero que le salio: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Cual fue el total de su compra: ");
                total = Convert.ToDouble(Console.ReadLine());
                if (numero <= 50)
                {
                    desc = total * 0.10;
                    totalDesc = total - desc;
                    Console.WriteLine("Este es el descuento que se le hace {0:C2} a su total sin descuento {1:C2} y este es su total con descuento {2:C2}", desc, total, totalDesc);
                }
                else
                {
                    desc = total * 0.15;
                    totalDesc = total - desc;
                    Console.WriteLine("Este es el descuento que se le hace {0:C2} a su total sin descuento {1:C2} y este es su total con descuento {2:C2}", desc, total, totalDesc);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se tienen que ingresar numeros");
            }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double TotalDesc
        {
            get { return totalDesc; }
            set { totalDesc = value; }
        }
    }
}

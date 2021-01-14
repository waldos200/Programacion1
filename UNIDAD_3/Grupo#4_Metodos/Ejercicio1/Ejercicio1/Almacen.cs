using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Almacen
    {
        private int cantidad;
        private double precio;
        double desc, totalDesc;

        public void Captura()
        {
            try
            {
                Console.Write("Ingresa la cantidad de camisas a comprar: ");
                cantidad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el precio de su compra: ");
                precio = Convert.ToDouble(Console.ReadLine());
                if (cantidad >= 2)
                {
                    desc = precio * 0.20;
                    totalDesc = precio - desc;
                    Console.WriteLine("El total a pagar es: $" + totalDesc);
                    Console.WriteLine("El descuento aplicado es: $" + desc);
                }
                else
                {
                    desc = precio * 0.10;
                    totalDesc = precio - desc;
                    Console.WriteLine("El total a pagar es: $" + totalDesc);
                    Console.WriteLine("El descuento aplicado es: $" + desc);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ingreso no valido!");
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double TotalDesc
        {
            get { return totalDesc; }
            set { totalDesc = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Automovil
    {
        public string marca, color;
        public int anio = 0;

        public Automovil(string marca, string color, int anio)
        {
            this.marca = marca;
            this.color = color;
            this.anio = anio;
        }

        public void Mostrar()
        {
            Console.WriteLine("Venta de Automóviles");
            Console.WriteLine("\nEsta es la marca del vehiculo: {0} " +
                              "\nEste es el color del vehiculo: {1} " +
                              "\nEste es el año del vehiculo: {2}", marca, color, anio);
        }
    }
}

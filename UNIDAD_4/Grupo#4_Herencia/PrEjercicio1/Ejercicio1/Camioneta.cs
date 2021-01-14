using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Camioneta : Automovil
    {
        public string motor;
        public string combustible;

        public Camioneta(string marca, string color, int anio, string motor, string combustible) : base (marca, color, anio)
        {
            this.marca = marca;
            this.color = color;
            this.anio = anio;
            this.motor = motor;
            this.combustible = combustible;
        }
        
        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Este es el tipo de motor: {0} " +
                            "\nTiene combustible: {1}", motor, combustible);
        }
    }
}

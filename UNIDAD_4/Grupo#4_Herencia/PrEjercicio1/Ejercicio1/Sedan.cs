using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Sedan : Automovil
    {
        public string modelo;
        public int cant_puertas;

        public Sedan(string marca, string color, int anio, string modelo, int cant_puertas) : base(marca, color, anio)
        {
            this.marca = marca;
            this.color = color;
            this.anio = anio;
            this.modelo = modelo;
            this.cant_puertas = cant_puertas;
        }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("El modelo es: {0} " +
                            "\nLa cantidad de puertas son: {1}", modelo, cant_puertas);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Perro
{
    class Mascota
    {
        public string tipo, nombre, sexo, edad;

        // Constructor
        public Mascota()
        {
            tipo = "perro";
            nombre = "Flipper";
            sexo = "macho";
            edad = "2 años";
        }

        // Método que muestra la información 
        public void Mostrar()
        {
            Console.WriteLine("Mi mascota es un " + tipo + " su nombre es " + nombre + " es " + sexo + " y tiene " + edad);
        }
    }
}

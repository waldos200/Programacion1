using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrContructor_Perro2
{
    class MAscota
    {
        public string tipo, nombre, sexo, edad;

        // Constructor
        public MAscota()
        {
            tipo = "perro";
            nombre = "Flipper";
            sexo = "macho";
            edad = "2 años";
            Mostrar(); // Llamando al método dentro del constructor
        }

        public void Mostrar()
        {
            Console.WriteLine("Mi mascota es un " + tipo + " su nombre es " + nombre + " es " + sexo + " y tiene " + edad);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Perro3
{
    class Mascota
    {
        public string tipo, nombre, sexo, edad;

        // Constructor personalizado o con parámetros
        public Mascota(string t, string n, string s, string e)
        {
            tipo = t;
            nombre = n;
            sexo = s;
            edad = e;
            Console.WriteLine("Mi mascota es un " + tipo + " su nombre es " + nombre + " es " + sexo + " y tiene " + edad);
        }
    }
}

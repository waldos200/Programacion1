using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio3
{
    class Persona
    {
        private string nombre;
        private string genero;
        private int edad;

        public Persona(string nombre, string genero,  int edad)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.edad = edad;

        }
        public void Mostrar()
        {
            Console.WriteLine("\tNombre     : {0}", nombre);
            Console.WriteLine("\tGenero     : {0}", genero);
            Console.WriteLine("\tEdad       : {0}", edad);

        }


    }
}

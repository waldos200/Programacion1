using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio5
{
    class Perro : Mascotas
    {
        public string raza;
        public int edad;

        public Perro()
        {
            Console.WriteLine("\nDatos de mi Perro");
        }
        public new void Mostrar()
        {
            Console.WriteLine("\nPERRO");
            Console.WriteLine("Su raza es: " + raza);
            Console.WriteLine("Su edad en años es: " + edad);
            base.Mostrar();
        }
    }
}
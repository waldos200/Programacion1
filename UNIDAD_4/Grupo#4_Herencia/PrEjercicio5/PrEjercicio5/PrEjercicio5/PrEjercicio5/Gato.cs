using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio5
{
    class Gato : Mascotas
    {
        public string nombre;

        public Gato()
        {
            Console.WriteLine("Datos de mi Gato");
        }

        public new void Mostrar()
        {
            Console.WriteLine("\nGATO");
            Console.WriteLine("Su nombre es: " + nombre);
            base.Mostrar();
        }
    }
}
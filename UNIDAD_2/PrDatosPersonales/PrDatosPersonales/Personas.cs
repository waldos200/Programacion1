using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrDatosPersonales
{
    class Personas
    {
        /* Estas variables no serán necesarias declaradas
        // public string nombre, apellido;
        // public int edad;
         */

        // Con captura de datos si serán necesarias las variables
        public string nombre, apellido;
        public int edad;

        // Metodo de captura
        public void Captura()
        {
            Console.Write("Digite el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Digite el apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Digite la edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
        }

        // Creacion de método con parámetro

        public void DatosPersonales(string nombre, string apellido, int edad)
        {
            Console.WriteLine("\n" + nombre + " " + apellido + " tiene " + edad + " años de edad");
        }
    }
}

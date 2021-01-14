using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrDatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creando objeto
            Personas p1 = new Personas();

            /*// Invocando el método y enviandole argumentos
            p1.DatosPersonales("Jose", "Lopez", 21);*/

            // Capturando datos 
            /* Console.Write("Digite el nombre: ");
            p1.nombre = Console.ReadLine();
            Console.Write("Digite el apellido: ");
            p1.apellido = Console.ReadLine();
            Console.Write("Digite la edad: ");
            p1.edad = Convert.ToInt32(Console.ReadLine()); */

            // Invocando el método y enviandole argumentos
            /* p1.DatosPersonales(p1.nombre, p1.apellido, p1.edad); */

            // Invocando los métodos
            p1.Captura();
            p1.DatosPersonales(p1.nombre, p1.apellido, p1.edad);
            Console.ReadKey();
        }
    }
}

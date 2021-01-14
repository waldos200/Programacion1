using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrMascota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creando el objeto de la mascota
            Mascota m1 = new Mascota();
            // invocando el método Mostrar
            m1.Mostrar();
            Console.ReadKey();
        }
    }
}

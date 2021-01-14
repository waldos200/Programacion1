using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona(); // Creando un objeto
            // Invocando los metodos
            p1.Captura();
            p1.MostrarInfo();
            Console.ReadKey();
        }
    }
}

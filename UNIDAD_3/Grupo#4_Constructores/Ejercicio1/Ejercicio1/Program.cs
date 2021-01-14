using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante();

            e1.Captura();

            e1.Estudiar(e1.NCarrera);


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadDemo
{
    class Program
    {
        static void Main()
        {
            PropSencilla ob = new PropSencilla();
            Console.WriteLine("Valor original de ob.MiProp: " + ob.MiProp);
            ob.MiProp = 100; // Asignar un valor
            Console.WriteLine("Valor de ob.MiProp: " + ob.MiProp);
            // No puede asignar un valor negative a prop.
            Console.WriteLine("Intentando asignar -10 a ob.MiProp");
            ob.MiProp = -10;
            Console.WriteLine("VAlor de ob.MiProp: " + ob.MiProp);
            Console.ReadKey();
        }
    }
}

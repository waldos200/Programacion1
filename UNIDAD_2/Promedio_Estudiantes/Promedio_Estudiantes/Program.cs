using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            PromedioParametros obj = new PromedioParametros();
            obj.MostrarInfo("25-045-2016", "Roberto", "Gray");
            Console.WriteLine("El promedio es: {0:#.#}", obj.Promedio(6.5, 8.6, 9.5, 7.4, 5.3));
            Console.ReadKey();
        }
    }
}

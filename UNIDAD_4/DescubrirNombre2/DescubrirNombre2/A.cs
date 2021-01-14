using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescubrirNombre2
{
    // Llamar a un método oculto.
    class A
    {
        public int i = 0;
        // Mostrar() en A
        public void Mostrar()
        {
            Console.WriteLine("i en la clase base: " + i);
        }
    }
}

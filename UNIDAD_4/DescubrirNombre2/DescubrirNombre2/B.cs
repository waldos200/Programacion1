using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescubrirNombre2
{
    // Crear una clase derivada
    class B : A
    {
        new int i; // Esta i oculta la i en A
        public B(int a, int b)
        {
            base.i = a; // Esto descubre la i en A
            i = b; // i en B
        }
        // Esto oculta a Mostrar() en A. Observe el uso de new
        new public void Mostrar()
        {
            base.Mostrar(); // Esto llama a Mostrar() en A
            // Esto muestra la i en B
            Console.WriteLine("i en la clase derivada: " + i);
        }
    }
}

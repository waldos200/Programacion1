using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescubrirNombre
{
    // Crear una clase derivada
    class B : A
    {
        new int i; // Esta i oculta la i en A
        public B(int a,int b)
        {
            base.i = a; // Esto descubre la i en A
            i = b; // i en B
        }
        public void Mostrar()
        {
            // Esto muestra la i en A
            Console.WriteLine("i en la clase base: " + base.i);
            // Esto muestra la i en B
            Console.WriteLine("i en la clase derivada: " + i);
        }
    }
}

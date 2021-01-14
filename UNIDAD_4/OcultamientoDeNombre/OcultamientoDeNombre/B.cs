using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcultamientoDeNombre
{
    // Crear una clase derivada
    class B : A
    {
        new int i; // esta i oculta la i en A
        public B(int b)
        {
            i = b; // i en B
        }
        public void Mostrar()
        {
            Console.WriteLine("i en la clase derivada: " + i);
        }
    }
}

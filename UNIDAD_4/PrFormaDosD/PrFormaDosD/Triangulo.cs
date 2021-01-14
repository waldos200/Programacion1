using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrFormaDosD
{
    class Triangulo:FormaDosD
    {
        public string estilo; // Estilo de triangulo
        // Devolver el área de un triangulo.
        public double Area()
        {
            return ancho * alto / 2;
        }
        // Mostrar el estilo del triangulo.
        public void MostrarEstilo()
        {
            Console.WriteLine("El triangulo es " + estilo);
        }
    }
}

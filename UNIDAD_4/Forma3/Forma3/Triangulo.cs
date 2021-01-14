using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma3
{
    class Triangulo : FormaDosD
    {
        string estilo;
        // Constructor
        public Triangulo(string s, double w, double h)
        {
            Ancho = w; // inicializa la clase base
            Alto = h; // inicializa la clase base
            estilo = s; // inicializa la clase base
        }
        // Devuelve el area del triangulo
        public double Area()
        {
            return Ancho * Alto / 2;
        }
        // Muestra el estilo de un triangulo
        public void MostrarEstilo()
        {
            Console.WriteLine("El triangulo es " + estilo);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma4
{
    class Triangulo : FormaDosD
    {
        string estilo;
        /* Un constructor por defecto. Esto invoca manualmente
         al contructor por deecto de FormaDosD. */
        public Triangulo()
        {
            estilo = "null";
        }
        // Constructor que toma tres argumentos.
        public Triangulo(string s, double w, double h) : base(w, h)
        {
            estilo = s;
        }
        // Constructor para un triangulo isosceles
        public Triangulo(double x) : base(x)
        {
            estilo = "isosceles";
        }
        // Devolver el area de un triagulo
        public double Area()
        {
            return Ancho * Alto / 2;
        }
        // Mostrar el estilo de un triangulo 
        public void MostrarEstilo()
        {
            Console.WriteLine("El triangulo es " + estilo);
        }
    }
}

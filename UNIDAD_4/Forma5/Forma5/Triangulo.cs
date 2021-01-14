using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma5
{
    class Triangulo : FormaDosD
    {
        string estilo;
        // Llamar al constructor de la clase base
        public Triangulo(string s, double w, double h) : base(w, h)
        {
            estilo = s;
        }
        // Devolver el area del triangulo
        public double Area()
        {
            return Ancho * Alto / 2;
        }
        // Mostrar el estilo del triangulo
        public void MostrarEstilo()
        {
            Console.WriteLine("El triangulo es " + estilo);
        }
    }
}

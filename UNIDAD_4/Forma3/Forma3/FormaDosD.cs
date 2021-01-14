using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma3
{
    class FormaDosD
    {
        double pri_ancho;
        double pri_alto;
        // Propiedades para ancho y alto
        public double Ancho
        {
            get { return pri_ancho; }
            set { pri_ancho = value < 0 ? -value : value; }
        }
        public double Alto
        {
            get { return pri_alto; }
            set { pri_alto = value < 0 ? -value : value; }
        }
        public void MostrarDim()
        {
            Console.WriteLine("El ancho y alto son " + Ancho + " y " + Alto);
        }
    }
}

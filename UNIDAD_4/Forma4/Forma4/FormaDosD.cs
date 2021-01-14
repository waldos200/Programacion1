using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma4
{
    class FormaDosD
    {
        double pri_ancho;
        double pri_alto;
        // Constructor por defecto
        public FormaDosD()
        {
            Ancho = Alto = 0.0;
        }
        // Constructor para FormaDosD
        public FormaDosD(double w, double h)
        {
            Ancho = w;
            Alto = h;
        }
        // Construye un objeto con el alto y ancho
        public FormaDosD(double x)
        {
            Ancho = Alto = x;
        }
        // Propiedades para Ancho y Alto
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

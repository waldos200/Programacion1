using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// El accesp a los miembros privados no es heredado.
// Una clase para objetos de dos dimensiones.
namespace FormasDosD_2
{
    class FormaDosD
    {
        private double ancho, alto;

        public void MostrarDim()
        {
            Console.WriteLine("El ancho y alto son " + ancho + " y " + alto);
        }
        // Propiedades para las variables privadas
        public double Anchura
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public double Altura
        {
            get { return alto; }
            set { alto = value; }
        }
    }

    // La clase triangulo es derivada de FormaDosD
    class Triangulo : FormaDosD
    {
        public string estilo; // Estilo de triangulo
        // Devolver el area de un triangulo
        public double Area()
        {
            return Anchura * Altura / 2;
        }
        // Mostrar el estilo del triangulo
        public void MostrarEstilo()
        {
            Console.WriteLine("Ell triangulo es " + estilo);
        }
    }
}

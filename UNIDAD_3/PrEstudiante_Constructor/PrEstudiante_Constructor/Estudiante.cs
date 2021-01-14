using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiante_Constructor
{
    class Estudiante
    {
        public string carnet, nombre, apellido;
        private double nota1, nota2, nota3;

        public Estudiante()
        {
            Console.WriteLine("Digite los datos del estudiante...");
        }

        public double Promedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("\n----------Datos del estudiante----------");
            Console.WriteLine("Carnet: " + carnet);
            Console.WriteLine("Nombre Completo: " + nombre + " " + apellido);
            Console.WriteLine("El promedio es: " + Promedio());
        }

        // Propiedades
        public double N1
        {
            get { return nota1; }
            set { nota1 = value; }
        }
        public double N2
        {
            get { return nota2; }
            set { nota2 = value; }
        }
        public double N3
        {
            get { return nota3; }
            set { nota3 = value; }
        }
    }
}

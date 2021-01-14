using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiante_Constructor2
{
    class Estudiante
    {
        public string carnet, nombre, apellido;
        private double nota1, nota2, nota3;

        // Constructor personalizado
        public Estudiante(string carnet, string nombre, string apellido, double n1, double n2, double n3)
        {
            this.carnet = carnet;
            this.nombre = nombre;
            this.apellido = apellido;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
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
            set
            {
                if (value >= 0)
                    nota1 = value;
                else
                    Console.WriteLine("Error, la nota debe ser mayor o igual a cero");
            }
        }
        public double N2
        {
            get { return nota2; }
            set
            {
                if (value >= 0)
                    nota1 = value;
                else
                    Console.WriteLine("Error, la nota debe ser mayor o igual a cero");
            }
        }
        public double N3
        {
            get { return nota3; }
            set
            {
                if (value >= 0)
                    nota1 = value;
                else
                    Console.WriteLine("Error, la nota debe ser mayor o igual a cero");
            }
        }
    }
}

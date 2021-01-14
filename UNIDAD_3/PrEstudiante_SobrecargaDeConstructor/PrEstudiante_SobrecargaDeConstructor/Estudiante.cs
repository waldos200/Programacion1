using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEstudiante_SobrecargaDeConstructor
{
    class Estudiante
    {
        public string carnet, nombre, apellido;
        private double nota1, nota2, nota3;

        // Sobrecarga de constructures
        // Constructor por omisión
        public Estudiante()
        {
            Console.WriteLine("Digite los datos del estudiante...");
        }

        // Constructor personalizado
        public Estudiante(string c, string n, string a, double n1, double n2, double n3) 
        {
            carnet = c;
            nombre = n;
            apellido = a;
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
            Console.WriteLine("carnet:" + carnet);
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

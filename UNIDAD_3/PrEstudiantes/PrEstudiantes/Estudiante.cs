using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace PrEstudiantes
{
    class Estudiante
    {
        public string carnet, nombre, apellido;
        public double n1, n2, n3;

        // Constructor por omision
        public Estudiante()
        {
            Console.WriteLine("Capturando datos...");
        }

        // Constructor personalizado
        public Estudiante(string car, string nom, string ape, double n1, double n2, double n3)
        {
            carnet = car;
            nombre = nom;
            apellido = ape;
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }

        // Metodos
        public void Promedio()
        {
            double prom = (n1 + n2 + n3) / 3;
            Console.WriteLine("El promedio es: " + prom);
            if (prom >= 6)
                Console.WriteLine("\"Aprobado\"");
            else
                Console.WriteLine("\"Reprobado\"");
        }

        public string NombreCompleto(string nombre, string apellido)
        {
            return nombre + " " + apellido;
        }

        public void Mostrar()
        {
            Console.WriteLine("\n**********Datos del estudiante**********");
            Console.WriteLine("Carnet: " + carnet + "\nNombre Completo: " + NombreCompleto(nombre, apellido));
            Promedio();
        }
    }
}

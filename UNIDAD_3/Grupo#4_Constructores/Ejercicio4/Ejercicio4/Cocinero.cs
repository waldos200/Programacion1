using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cocinero
    {
        private string nombre;
        private string especialidad;
        private int edad;


        public Cocinero()
        {
            Console.WriteLine("\n\t \"Capturando datos del cocinero...\"");
        }

        public void MostrarDatos(string nombre, string especialidad, int edad)
        {

            this.nombre = nombre;
            this.especialidad = especialidad;
            this.edad = edad;

            Console.WriteLine("\n\n\n\n\t\t\tDatos del cocinero\n\n\t\t\tNombre: " + nombre + "\n\n\t\t\tEspecialidad: " + especialidad + "\n\n\t\t\tEdad: " + edad);
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio3
{
    class Alumno : Persona
    {
        public string carne;
        public double nota1;
        public double nota2;
        public double nota3;
        public int cant_mat;
        public Alumno(string nombre, string genero, int edad,string carne, double nota1, double nota2, double nota3, int cant_mat) : base(nombre,genero, edad)
        {

            this.carne = carne;
            this.nota1=nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.cant_mat = cant_mat;
            Console.WriteLine("\n\n\t================");
            Console.WriteLine("\tDatos del Alumno");
            Console.WriteLine("\t================");
        }

        public new void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("\tNota 1     : {0}", this.nota1);
            Console.WriteLine("\tNota 2     : {0}", this.nota2);
            Console.WriteLine("\tNota 3     : {0}", this.nota3);
            Console.WriteLine("\tCant Mat   : {0}", this.cant_mat);

        }
        public double Promedio() 
        {
            return (nota1+ nota2+ nota3)/3;
        }

    }
}

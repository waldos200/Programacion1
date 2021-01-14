using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PrMascota
{
    class Mascota
    {
        // Atributos de la clase
        public string tipo, nombre, sexo;
        public int edad;
    }
}

namespace PrMascota
{
    class Program
    {
        static void Main(String[] args)
        {
            // Creando 2 objetos de la clase Mascota
            Mascota m1 = new Mascota();
            Mascota m2 = new Mascota();

            // Asignando datos con cada objeto 
            m1.tipo = "perro";
            m1.nombre = "Dogui";
            m1.sexo = "macho";
            m1.edad = 2;
            m2.tipo = "gato";
            m2.nombre = "Mimi";
            m2.sexo = "hembra";
            m2.edad = 4;

            // Imprimiendo datos con cada objeto
            Console.WriteLine("=========Datos de la mascota 1=========");
            Console.WriteLine("Tipo mascota: " + m1.tipo + "\nNombre: " + m1.nombre + "\nSexo: " + m1.sexo + "\nEdad: " + m1.edad);
            Console.WriteLine("=========Datos de la mascota 2=========");
            Console.WriteLine("Tipo mascota: " + m2.tipo + "\nNombre: " + m2.nombre + "\nSexo: " + m2.sexo + "\nEdad: " + m2.edad);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrMascota
{
    class Mascota
    {
        // Atributos de la clase
        public string tipo, nombre, sexo;
        public int edad;

        public Mascota()
        {
            Console.WriteLine("Capturando datos de la mascota...");
            Captura(); // Invocando al método que captura los datos
        }

        public void Captura()
        {
            Console.Write("Digite el tipo de mascota: ");
            tipo = Console.ReadLine();
            Console.Write("Digite el tipo de mascota: ");
            nombre = Console.ReadLine();
            Console.Write("Digite el tipo de mascota: ");
            sexo = Console.ReadLine();
            try // Se hace uso de try y catch para la edad porque es un dato numérico
            {
                Console.Write("Digite la edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error dato no válido " + ex.Message);
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("\n==========Datos de la mascota==========");
            Console.WriteLine("Tipo mascota: " + tipo + "\nNombre: " + nombre + "\nSexo: " + sexo + "\nEdad: " + edad);
        }
    }
}

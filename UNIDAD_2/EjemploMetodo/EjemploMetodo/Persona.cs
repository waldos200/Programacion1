using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjemploMetodo
{
    class Persona
    {
        public string nombre, apellido;

        public void Captura()
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();
        }
        public string Saludo()
        {
            return "Que tengas buen dia!!";
        }
        public void MostrarInfo()
        {
            Saludo();
            Console.WriteLine(nombre + " " + apellido);
        }
    }
}

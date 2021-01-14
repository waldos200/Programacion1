using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNueva
{
    class Vendedores
    {
        private string nombres, apellidos, direccion;
        public void guardarV()
        {
            /* Los datos usted los puede asignar desde el
                teclado o simplemente asignarles datos, todo
                               depende del enunciado del problema */
            nombres = "Jorge Alberto";
            apellidos = "Acevedo Diaz";
            direccion = "San Salvador";
        }
        public void imprimirV()
        {
            Console.WriteLine("Los datos del vendedor son: ");
            Console.WriteLine("Nombres: " + nombres);
            Console.WriteLine("Apellidos: " + apellidos);
            Console.WriteLine("Ciudad: " + direccion);
        }
    }
}

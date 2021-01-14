using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNueva
{
    class Productos : Vendedores
    {
        public string nombre, descripcion;
        public double precio;
        public void guardarP()
        {
            /* Los datos usted los puede asignar desde el 
                teclado o simplemente asignarle datos, todo
                            depende del enunciado del problema */
            nombre = "Camisa";
            descripcion = "Camisa de color Roja";
            precio = 25.75;
        }
        public void imprimirP()
        {
            Console.WriteLine("Los datos del Producto son: ");
            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("La descripcion: " + descripcion);
            Console.WriteLine("El precio: " + precio);
        }
    }
}

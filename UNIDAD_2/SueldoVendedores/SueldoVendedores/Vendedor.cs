using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace SueldoVendedores
{
    class Vendedor
    {
        public string codigo, nombre, apellido;
        public int edad;
        public double ventas, sueldo_base;
        // Creación de métodos
        public void Datos()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite el codigo: ");
                codigo = Console.ReadLine();
                Console.Write("Digite el nombre del vendedor: ");
                nombre = Console.ReadLine();
                Console.Write("Digite el apellido: ");
                apellido = Console.ReadLine();
                Console.Write("Digite la edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite el sueldo base: ");
                sueldo_base = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite las ventas del mes: ");
                ventas = Convert.ToDouble(Console.ReadLine());
                Mostrar();
            }
        }
        public void Mostrar()
        {
            Console.WriteLine("\n==========Información del vededor==========");
            Console.WriteLine("Codigo del vededor: " + codigo + "\nNombre: " + nombre + " " + apellido + "\nEdad: " + edad + "\nSueldo base: " + sueldo_base + "\nVentas: " + ventas + "\nComision: $" + Comision() + "\nSueldo neto: $" + CalculoSueldo());
        }
        public double Comision()
        {
            return ventas * 0.20;
        }
        public double CalculoSueldo()
        {
            double sueldo_neto; // Declaración de variables del metodo
            sueldo_neto = sueldo_base + Comision();
            return sueldo_neto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseVendedor
{
    class Vendedor
    {
        public int edad;
        public string codigo, nombre, apellido;
        public double sueldo_base, ventas;

        public void Captura()
        {
            for (int i = 1; i <= 2; i++)
            {
                try
                {
                    Console.Write("\nIngrese el codigo del vendedor: ");
                    codigo = Console.ReadLine();
                    Console.Write("Ingrese el nombre del vendedor: ");
                    nombre = Console.ReadLine();
                    Console.Write("Ingrese el apellido del vendedor: ");
                    apellido = Console.ReadLine();
                    Console.Write("Ingrese edad: ");
                    edad = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el sueldo base: ");
                    sueldo_base = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el valor total de las ventas: ");
                    ventas = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error datos no válidos " + ex.Message);
                }
                Mostrar();
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("\nCodigo del vendedor: " + codigo);
            Console.WriteLine("Nombre completo: " + nombre + " " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Sueldo base: " + sueldo_base);
            Console.WriteLine("Total ventas: " + ventas);
            Console.WriteLine("La comision es de: " + Comision());
            Console.WriteLine("El salario neto es de: " + SalarioNeto());
        }

        public double Comision()
        {
            return ventas * 0.20;
        }

        public double SalarioNeto()
        {
            return sueldo_base + Comision();
        }
    }
}

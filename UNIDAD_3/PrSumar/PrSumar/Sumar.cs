using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrSumar
{
    class Sumar
    {
        // Variables privadas
        private int num1, num2;

        // Método de captura para las variables
        public void Captura()
        {
            try
            {
                Console.Write("Digite un numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite otro numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Los valores son: num1=" + num1 + " num2=" + num2);
            }
            catch
            {
                Console.WriteLine("Error datos no vállidos");
            }
        }

        // Método con 2 parámetros, mostrará la suma de los números
        public void Suma(int num1, int num2)
        {
            Console.WriteLine("La suma es: " + (num1 + num2));
        }

        // Propiedades para la variable num1
        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        // Propiedades para la variable num2
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
    }
}

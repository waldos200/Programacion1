using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Sumar
    {
        private int num1, num2;

        public void Captura()
        {
            try
            {
                Console.Write("Digite un numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite otro numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nLos valores son num1= " + num1 + " num2= " + num2);
            }
            catch
            {
                Console.WriteLine("Error datos no vállidos");
            }
        }

        public void Suma(int num1, int num2)
        {
            Console.WriteLine("\nLa suma es: " + (num1 + num2));
        }

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
    }
}

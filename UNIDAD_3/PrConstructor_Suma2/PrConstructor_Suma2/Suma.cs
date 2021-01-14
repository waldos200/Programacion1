using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrConstructor_Suma2
{
    class Suma
    {
        public int num1, num2;
        // Constructor con parámetros
        public Suma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        // Método que retorna la suma
        public int Sumar()
        {
            return num1 + num2;
        }

        // Método de captura 
        public void Captura()
        {
            try
            {
                Console.Write("Digite un numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite otro numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error datos no válidos");
            }
        }
    }
}

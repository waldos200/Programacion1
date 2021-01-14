using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Suma:Operacion
    {
        public void Operar()
        {
            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
        }
    }
}

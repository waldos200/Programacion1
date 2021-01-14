using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Resta:Operacion
    {
        public void Operar()
        {
            Console.Write("\nIngrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
        }
    }
}

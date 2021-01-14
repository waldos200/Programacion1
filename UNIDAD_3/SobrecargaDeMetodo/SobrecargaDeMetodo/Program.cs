using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaDeMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sobrecarga obj = new Sobrecarga();
            obj.Metodos();
            obj.Metodos(5);
            Console.WriteLine(obj.Metodos(4, 6));
            obj.Metodos(5.2, 6.3);
            Console.ReadKey();
        }
    }
}

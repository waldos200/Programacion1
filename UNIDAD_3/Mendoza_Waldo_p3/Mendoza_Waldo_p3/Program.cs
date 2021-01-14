using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza_Waldo_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            Universidad e1 = new Universidad();
            while (resp == "s")
            {
                Console.Write("\nDigite si usted es estudiante de \nAntiguo ingreso = A \nNuevo ingreso = N\nIngrese una letra: ");
                e1.categoria = Console.ReadLine().ToUpper();
                try
                {
                    Console.Write("Digite cuantas materias llevara: ");
                    e1.num = Convert.ToInt32(Console.ReadLine());
                    if (e1.num == 0)
                    {
                        Console.Write("Digite un numero que no sea 0: ");
                        e1.num = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Digite un numero");
                    Console.Write("Digite cuantas materias llevara: ");
                    e1.num = Convert.ToInt32(Console.ReadLine());
                }
                e1.Mostrar();

                Console.Write("\nDesea continuar s/n: ");
                resp = Console.ReadLine().ToLower();
            }
            Console.ReadKey();
        }
    }
}

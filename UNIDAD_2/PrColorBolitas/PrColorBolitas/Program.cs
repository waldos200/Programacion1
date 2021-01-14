using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrColorBolitas
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolita, i;
            double compra;

            for (i = 1; i <= 5; i++)
            {
                try
                {
                    Console.Write("Digite el total de la compra: ");
                    compra = Convert.ToDouble(Console.ReadLine());
                    if (compra >= 30)
                    {
                        try
                        {
                            Console.Write("Ingrese el numero de la bolita: ");
                            bolita = Convert.ToInt32(Console.ReadLine());
                            switch (bolita)
                            {
                                case 1:
                                    Console.WriteLine("1 Shampoo");
                                    break;
                                case 2:
                                    Console.WriteLine("1 paquete de 3 jabones");
                                    break;
                                case 3:
                                    Console.WriteLine("1 pasta de dientes");
                                    break;
                                case 4:
                                    Console.WriteLine("1 bolsa de detergente");
                                    break;
                                case 5:
                                    Console.WriteLine("1 caja de cereal de chocolate");
                                    break;
                                default:
                                    Console.WriteLine("Numero no existe");
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            i--;
                        }
                    }
                    else
                        Console.WriteLine("No aplica premio");
                }
                catch
                {
                    Console.WriteLine("Error, dato no valido");
                    i--;
                }
                Console.ReadKey();
            }
        }
    }
}

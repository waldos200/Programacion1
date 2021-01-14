using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea objeto
            SueldoNeto SN = new SueldoNeto();
            //Se Piden los datos de los 10 empleados
            for (int i = 1; i <= 10; i += 1)
            {
                try
                {
                    Console.Write("======== CALCULO DE SUELDO NETO ========== \n ");
                    Console.Write("========     Empleado N. {0}    ========== \n ", i);

                    Console.Write("Ingrese el nombre del empleado : ");
                    SN.Nombre = Console.ReadLine();
                    Console.Write("Ingrese el Salario Base : ");
                    SN.Sueldo_Base = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el Valor de las Ventas : ");
                    SN.Ventas = Convert.ToDouble(Console.ReadLine());


                    //Calcula el sueldo Neto
                    if (SN.CalculoSueldoNeto(SN.Sueldo_Base, SN.Ventas) != true)
                    {
                        i -= 1;
                    }
                    Console.Write("\n");
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    i -= 1;
                }

            }
            Console.ReadKey();
        }
    }
}

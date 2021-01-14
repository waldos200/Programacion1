using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class SueldoNeto
    {
        //Se declaran las variables
        public string Nombre;
        public double Ventas = 0, Sueldo_Base = 0;

        public Boolean CalculoSueldoNeto(double Sueldo_Base, double Ventas)
        {
            try
            {

                double Comision = 0;
                double Sueldo_Neto = 0;
                double Aumento = 0;

                //Valida que no se permitan valores menores o iguales que cero
                if (Sueldo_Base <= 0)
                {
                    Console.Write("El Sueldo Base no puede ser Cero\n");
                    return false;
                }
                //Se calcula el Aumento
                if (Sueldo_Base >= 400)
                {
                    Aumento = Sueldo_Base * 0.10;
                }
                else
                {
                    Aumento = Sueldo_Base * 0.15;
                }
                //Calcula la comision de las ventas realizadas
                if (Ventas > 0)
                {
                    Comision = Ventas * 0.15;
                }
                //Se devuelve el SueldoNeto 
                Sueldo_Neto += Sueldo_Base + Aumento + Ventas + Comision;

                Console.Write("\n=========================================== ");
                Console.Write("\n       Sueldo Base : {0}", Sueldo_Base);
                Console.Write("\n       Aumento     : {0}", Aumento);
                Console.Write("\n       Ventas      : {0}", Ventas);
                Console.Write("\n       Comision    : {0}", Comision);
                Console.Write("\n=========================================== ");
                Console.Write("\n       Sueldo Neto : {0}", Sueldo_Neto);
                Console.Write("\n=========================================== ");
                Console.Write("\n");

                return true;

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }
    }
}

using System;
class Ejercicio10
{
    static void Main(string[] args)
    {
        double sueldo, descuento = 0, suelFin;
        for (int i = 0; i <= 20; i++)
        {
            Console.Write("Digite su sueldo: ");
            try
            {
                sueldo = Convert.ToDouble(Console.ReadLine());
                if (sueldo <= 1000)
                {
                    descuento = sueldo * 0.03;
                }
                else if (sueldo <= 2000)
                {
                    descuento = sueldo * 0.05;
                }
                else
                {
                    descuento = sueldo * 0.10;
                }
                suelFin = sueldo - descuento;
                Console.WriteLine("Este es su sueldo {0:C2}, este es el descuento {1:C2} y este es el sueldo final {2:C2}", sueldo, descuento, suelFin);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                i--;
            }
        }
    }
}
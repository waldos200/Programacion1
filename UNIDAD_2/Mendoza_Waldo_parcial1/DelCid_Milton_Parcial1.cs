using System;

class Horas_trabajo
{
    static void Main (string [] args)
    {
        int horas;
        double sueldo, unaHora, horasExtras, total;

        Console.WriteLine("Cuanto es el sueldo que gana en las 44 horas trabajadas: ");
        sueldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Cuantas horas extras trabajo: ");
        horas = Convert.ToInt32(Console.ReadLine());

        unaHora = sueldo / 44; 
         
        if (horas > 0) {
            horasExtras = unaHora * 2 * horas;
            total = sueldo + horasExtras;
            Console.WriteLine("Este es el extra a pagar: {0:C2} Este es el total a pagar: {1:C2}" , horasExtras, total);
        } else
            Console.WriteLine("No recibe pago extras");
    }
}
using System;

class UsoTryCatch1
{
    static void Main(string[] args)
    {
        int num1, num2, division;

        try
        {
            Console.Write("Ingrese el numero 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el numero 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            division = num1 / num2;
            Console.WriteLine("La division es: " + division);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
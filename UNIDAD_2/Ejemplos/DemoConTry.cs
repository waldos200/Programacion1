using System;
class DemoConTry
{
    static void Main()
    {
        int x = 0;
        try
        {
            Console.Write("Digite un numero enter: ");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Usted escribio: {0}", x);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Detalle del error: " + ex.ToString());
        }
    }
}
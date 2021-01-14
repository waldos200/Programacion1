using System;

class UsoTryCatch
{
    static void Main(string[] args)
    {
        int numero;

        for (int i = 1; i <= 3; i++)
        {
            try
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El numero ingresado es: " + numero);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error dato no valido " + ex.Message);
                i--;
            }
        }
    }
}
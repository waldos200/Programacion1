using System;
class ParImpar
{
    static void Main(string[] args)
    {
        int i, num;
        for (i = 1; i <= 10; i++)
        {
            try
            {
                Console.Write("Digite un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("El numero es 0");
                }
                else if (num % 2 == 0)
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
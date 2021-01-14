using System;

class Ejercicio1
{
	static void Main(string[] args)
	{
		int j, numero, suma;
		
		j= 1; suma= 0;
		
		Console.Write("\n\n");
				
		while (j<= 5)	
		{
			try
			{
				Console.Write("\n\tDigite un numero entero: ");
				numero= Convert.ToInt32(Console.ReadLine());
				
				if (numero%3== 0)
				{
					suma= suma + numero;
				}
				
				j++;
			}
			
			catch (FormatException ex)
			{
				Console.WriteLine("\n\t\tTipo de dato incorrecto: {0}", ex.Message);
				Console.WriteLine("\t\tContinue...");
			}
			
		}
		
		Console.WriteLine("\n\n\tLa suma de los numeros multiplos de tres es: {0}", suma);
	}
	
}	
	
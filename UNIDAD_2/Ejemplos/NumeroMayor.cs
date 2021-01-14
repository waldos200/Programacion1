using System;

class NumeroMayor
{
	static void Main(string [] args)
	{
		int num1, num2;
		
		// Capturando datos desde teclado
		Console.WriteLine("Digite el primer numero: ");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite el segundo numero: ");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		// Utilizando la estructura if
		if (num1 > num2){
			Console.WriteLine("El numero mayor es: " + num1);
		} else {
			Console.WriteLine("El numero mayor es: " + num2);
		}
	}
}
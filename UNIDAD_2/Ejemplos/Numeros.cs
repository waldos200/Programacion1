using System;

class Numeros
{
	static void Main(string [] args)
	{
		int num1, num2, resultado;
		
		// Capturando dato desde teclado
		Console.WriteLine("Digite primer numero:");
		num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite el segundo numero:");
		num2 = Convert.ToInt32(Console.ReadLine());
		
		// Utilizando la estructura if
		if (num1 == num2) {
			resultado = num1 * num2;
		} else if (num1 > num2) {
			resultado = num1 -num2;
		} else {
			resultado = num1 + num2;
		}
		Console.WriteLine("El resultado es: " + resultado);
	}
}
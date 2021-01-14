using System;

class ParImpar
{
	static void Main(string [] args)
	{
		int numero;
		
		// Captura el numero
		Console.WriteLine("Digite un numero: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		/* En la condicion se evalua el residuo para saber si es cero
		en ese caso el numero seria par, caso contrario impar*/
		if (numero % 2 == 0){
			Console.WriteLine("El numero es par");
		} else {
			Console.WriteLine("El numero es impar");
		}
	}
}
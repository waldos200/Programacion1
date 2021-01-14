using System;

class Vocales
{
	static void Main(string [] args)
	{
		char letra, vocal;
		
		Console.Write("Digite una letra: ");
		letra = Convert.ToChar(Console.ReadLine());
		vocal = Char.ToUpper(letra); // Convirtiendo a mayusculas lo capturado
		// Si se quiere convertir a minuscula se utiliza ToLower()
		
		switch(vocal) {
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
				Console.WriteLine("Es una vocal");
				break;
			default:
				Console.WriteLine("No es una vocal");
				break;
		}
	}
}
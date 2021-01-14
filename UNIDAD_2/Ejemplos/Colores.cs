using System;

class Colores
{
	static void Main(string [] args)
	{
		// Declaracion de variables
		double compra, desc, total_pagar;
		string color;
		
		// Captura de datos
		Console.Write("Digite la cantidad de la compra: ");
		compra = Convert.ToDouble(Console.ReadLine());
		Console.Write("Digite el color de la bolita: ");
		color = Console.ReadLine().ToLower(); // Convierte a minusculas lo digitado
		
		// Uso de la estructura switch para calcular el descuento
		switch (color){
			case "blanco":
				desc = 0;
				break;
			case "verde":
				desc = compra * 0.10;
				break;
			case "amarillo":
				desc = compra * 0.25;
				break;
			case "azul":
				desc = compra * 0.50;
				break;
			case "roa":
				desc = compra * 1.0;
				break;
			default:
				desc = 0;
				break;
		}
		
		total_pagar = compra - desc; // Calculando el total a pagar
		// Salida de datos solicitada
		Console.WriteLine("El descuento es de: $" + desc + "\nEl total a pagar es de: $" + total_pagar);
	}
}
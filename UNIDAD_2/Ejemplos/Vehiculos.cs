using System;

class Vehiculos
{
	static void Main(string [] args)
	{
		// Decalraciones de variables
		double total_pagar, desc, precio;
		string marca;
		
		// Captura de datos
		Console.Write("Digite la marca del vehiculo: ");
		marca = Console.ReadLine().ToLower(); // Convierte a minusculas lo digitado
		Console.Write("Digite el precio: ");
		precio = Convert.ToDouble(Console.ReadLine());
		
		// Uso de la estructura switch para validar la marca del vehiculo
		switch (marca){
			case "toyota":
				desc = precio * 0.10;
				break;
			case "nissan":
				desc = precio * 0.08;
				break;
			case "mazda":
				desc= precio * 0.05;
				break;
			case "honda":
				desc = precio * 0.03;
				break;
			default:
				desc = 0;
				break;
		}
		total_pagar = precio - desc; // Calculando el total a pagar
		// Salida de datos solicitada
		Console.WriteLine("El total a pagar por un {0} es de $:{1}, con un descuento de $:{2}", marca, total_pagar, desc);
	}
}
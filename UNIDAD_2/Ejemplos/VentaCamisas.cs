using System;

class VentaCamisas
{
	static void Main(string [] args)
	{
		// Declaracion de variables
		double total_pagar;
		int cant_cam;
		
		// Entrada de datos, solicitando la cantidad de camisas a comprar
		Console.Write("Digita la cantidad de camisas: ");
		cant_cam = Convert.ToInt32(Console.ReadLine());
		
		// Uso de estructura selectiva doble
		if (cant_cam > 3)
			total_pagar = cant_cam * 10;
		else
			total_pagar = cant_cam * 12;
		
		// Salida de datos utilizando salida con formato
		Console.WriteLine("El total a pagar por {0} camisas es de: {1}", cant_cam, total_pagar);
	}
}
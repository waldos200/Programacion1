using System;

class Utilidades
{
	static void Main(string [] args)
	{
		double salario, tiempo, utilidad;
		
		Console.WriteLine("Digite el salario:");
		salario = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Digite el tiempo de trabajo:");
		tiempo = Convert.ToDouble(Console.ReadLine());
		
		if (tiempo < 1) {
			utilidad = salario * 0.05;
		} else if (tiempo < 2) {
			utilidad = salario * 0.07;
		} else if (tiempo < 5) {
			utilidad = salario * 0.10;
		} else if (tiempo < 10) {
			utilidad = salario * 0.15;
		} else {
			utilidad = salario * 0.20;
		}
		Console.WriteLine("La utilidad es de: " + utilidad);
	}
}
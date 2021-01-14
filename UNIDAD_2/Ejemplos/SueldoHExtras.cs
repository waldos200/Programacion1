using System;

class SueldoHExtras
{
	static void Main(string [] args)
	{
		double ht, ph, sueldo_he, he; // Horas estras(he)
		
		// Inicializaos a cero el sueldo_he y he
		sueldo_he = 0;
		he = 0;
		
		Console.WriteLine("Digite horas trabajadas");
		ht = Convert.ToDouble(Console.ReadLine()); // Horas trabajadas(ht)
		Console.WriteLine("Digite el precio de la hora: ");
		ph = Convert.ToDouble(Console.ReadLine()); // Precio hora (ph)
		
		if (ht > 44) {
			he = ht - 44; // Calculo de cantidad de horas extras
			if (he <= 8) {
				sueldo_he = he*2*ph; // Calculo de sueldo_he cuando las horas no exeden de 8
			} else {
				sueldo_he = 8*2*ph+(he-8)*3*ph; // Calculo sueldo_he cuando las horas exceden de 8
			}
		} else {
			sueldo_he = 0;
		}
		Console.WriteLine("El sueldo de horas extras por " + he + " horas trabajadas es de: $"+ sueldo_he);
	}
}
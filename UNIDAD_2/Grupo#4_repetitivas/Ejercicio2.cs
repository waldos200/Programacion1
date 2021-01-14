using System;

class Ejercicio1
{
	static void Main(string[] args)
	{
		string sexo, carrera;
		int j, num_alumnos, edad;
		int sumaA, sumaB, sumaC;
		int alumnosA, alumnosB, alumnosC;
		double promedioA, promedioB, promedioC;
		
		j= 1; sumaA= 0; sumaB= 0; sumaC= 0;
		alumnosA= 1; alumnosB= 1; alumnosC= 1;
		
		Console.Write("\n\n\n\tDigite el numero de alumnos de la universidad: ");
		num_alumnos= Convert.ToInt32(Console.ReadLine());
		
		while (j<= num_alumnos)	
		{
			try
			{
				Console.Write("\n\t\tDigite la edad del alumno: ");
				edad= Convert.ToInt32(Console.ReadLine());
				
				Console.Write("\n\t\tSea \"M\" para masculino y \"F\" para femenino");
				Console.Write("\n\t\tDigite la letra concerniente al sexo del alumno: ");
				sexo= Console.ReadLine() .ToUpper();
				
				Console.Write("\n\t\tSean las carreras \"A\", \"B\" o \"C\"");
				Console.Write("\n\t\tDigite la letra concerniente a la carrera del alumno: ");
				carrera= Console.ReadLine() .ToUpper();
				
				if (carrera== "A")
				{
					if (sexo== "M")
						{
						sumaA= sumaA + edad;
						alumnosA++;
						}
						
				}
				else if(carrera== "B")
				{
					if (sexo== "M")
						{
						sumaB= sumaB + edad;
						alumnosB++;
						}
						
				}
				else
				{
					if (sexo== "M")
						{
						sumaC= sumaC + edad;
						alumnosC++;
						}
						
				}
				
				j++;
				Console.WriteLine("\n\t\t\tSiguiente...");
			}
			
			catch (FormatException ex)
			{
				Console.WriteLine("\n\t\tTipo de dato incorrecto: {0}", ex.Message);
				Console.WriteLine("\t\tContinue...");
			}
			
		}
		
		promedioA= sumaA / alumnosA;
		promedioB= sumaB / alumnosB;
		promedioC= sumaC / alumnosC;
		
		if ((promedioA< promedioB) && (promedioA< promedioC))
			{
				Console.WriteLine("\t\t\tProcesando...");
				Console.WriteLine("\n\n\tLa carrera \"A\" tiene el menor promedio de edad de los alumnos de sexo masculino");
			}
		
		else if ((promedioB< promedioA) && (promedioB< promedioC))
			{
				Console.WriteLine("\t\t\tProcesando...");
				Console.WriteLine("\n\n\tLa carrera \"B\" tiene el menor promedio de edad de los alumnos de sexo masculino");
			}
			
		else
			{
				Console.WriteLine("\t\t\tProcesando...");
				Console.WriteLine("\n\n\tLa carrera \"C\" tiene el menor promedio de edad de los alumnos de sexo masculino");
			}
			
	}
	
}	
	
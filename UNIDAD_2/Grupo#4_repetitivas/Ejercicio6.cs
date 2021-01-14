using System;

public class Ejercicio6
{
   public static void Main()
   {
	   //declaracion de variables
			int i, nota;
			double promedio;
			string Nombre, Calificaciones, sprom;
		
			Calificaciones = "";
			promedio= 0;
			sprom= "";
		//Datos del alumno
			Console.Write("Ingrese el nombre : ");
			Nombre = Console.ReadLine();
			
	   // Bucle de notas
       //----------------------------------------------------------
		for (i=1;i<=3;i++)
		try
		{
			Console.Write("Ingrese la nota " + i + " : " );
			nota = Convert.ToInt32(Console.ReadLine());
		
			//Convierte a letras
			switch (nota)
			{
				case 1:
				Calificaciones = Calificaciones  + "\n UNO " ;
				break;
				case 2:
				Calificaciones = Calificaciones + "\n DOS " ;
				break;
				case 3:
				Calificaciones = Calificaciones + "\n TRES " ;
				break;
				case 4:
				Calificaciones = Calificaciones + "\n CUATRO " ;
				break;
				case 5:
				Calificaciones = Calificaciones  + "\n CINCO " ;
				break;
				case 6:
				Calificaciones = Calificaciones  + "\n SEIS " ;
				break;
				case 7:
				Calificaciones = Calificaciones  + "\n SIETE " ;
				break;
				case 8:
				Calificaciones = Calificaciones  + "\n OCHO " ;
				break;
				case 9:
				Calificaciones = Calificaciones  + "\n NUEVE " ;
				break;
				case 10:
				Calificaciones = Calificaciones  + "\n DIEZ " ;
				break;
			}	
			
			if (i<=2)
				{
				promedio = promedio + (nota*.30);
				}
			else
				{
				promedio= promedio + (nota*.40)	;			
				}
			
			
		}
		catch (Exception ex)
		{
			Console.WriteLine("Errores : " + ex.Message);
		}
		
		//determina el promedio
		if (promedio < 6)
			{
				sprom = "MM";
			}
		else if (promedio >= 6 && promedio <= 8)
			{
				sprom = "B";
			}
		else if (promedio >8 && promedio<=9)
			{
				sprom = "MB";
			}
		else if (promedio > 9)
			{
				sprom = "E";
			}
			
		
		// Despliega el resultado
		//----------------------------------------------------------
		Console.WriteLine("ALUMNO : {0} \n CALIFICACIONES :  {1} \n PROMEDIO : {2} {3}", Nombre, Calificaciones, promedio, sprom);
		Console.Read();
		
   }
}
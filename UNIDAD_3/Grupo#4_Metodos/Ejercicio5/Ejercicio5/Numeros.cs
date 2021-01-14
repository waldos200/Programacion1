using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Numeros
    {
		public int j;
		public int suma_par = 0;
		public int suma_impar = 0;

		int[] valor = new int[20];
		public void Captura()

		{

			for (j = 0; j < 20; j++)
			{
				try
				{
					Console.Write("\n\tIngrese el valor {0} º :   ", (j + 1));
					valor[j] = Convert.ToInt32(Console.ReadLine());
				}

				catch (FormatException ex)
				{
					Console.WriteLine("\n\t\tTipo de dato incorrecto: {0}", ex.Message);
					Console.WriteLine("\t\tContinue...");
					j--;
				}
			}
		}

		public void Calculos()

		{
			Console.Write("\n\n\n\tLos valores pares son:    ");

			for (j = 0; j < 20; j++)
			{
				if (valor[j] % 2 == 0)
				{
					suma_par = suma_par + valor[j];
					Console.Write(" {0}  ", valor[j]);
				}
			}

			Console.Write("\n\n\tLos valores impares son:  ");

			for (j = 0; j < 20; j++)
			{
				if (valor[j] % 2 != 0)
				{
					suma_impar = suma_impar + valor[j];
					Console.Write(" {0}  ", valor[j]);
				}
			}
		}

		public void Resultados()

		{
			Console.Write("\n\n\n\n\tLa suma de los valores pares es:   {0}", suma_par);
			Console.Write("\n\n\tLa suma de los valores impares es: {0}", suma_impar);
		}
	}
}

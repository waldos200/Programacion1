using System;

class SwitchDemo
{
	static void Main(string [] args)
	{
		char ch;
		
		Console.WriteLine("Digite una letra:");
		ch = Convert.ToChar(Console.ReadLine());
		
		switch (ch){
			case 'A':
				Console.WriteLine("La letra es A");
				break;
			case 'E':
				Console.WriteLine("La letra es E");
				break;
			case 'I':
				Console.WriteLine("La letra es I");
				break;
			case 'O':
				Console.WriteLine("La letra es O");
				break;
			case 'U':
				Console.WriteLine("La letra es U");
				break;
			default:
				Console.WriteLine("La letra es cualquier otro caracter");
				break;
		}
	}
}
using System;
class Ejercicio7
{
    static void Main()
    {
		int cantidad=0;
        string nombre, seguir;
		double compra, total_compra=0;

        do
        {
            Console.Write("Ingrese el nombre del cliente: ");
            nombre = Console.ReadLine();
			Console.Write("Digite el total de la compra: $");
			compra=Convert.ToDouble(Console.ReadLine());
            total_compra += compra;
			cantidad++;

            Console.Write("\nDesea continuar s/n ?");
            seguir = Console.ReadLine().ToLower();
       
            while (seguir != "s" && seguir != "n")
            {
                Console.Write("\nDesea continuar s/n ? ");
                seguir = Console.ReadLine().ToLower();
            }
        } while (seguir == "s");
			Console.WriteLine("\n====================================");
			Console.WriteLine("\nEl total de las compras es de: $" + total_compra);
			Console.WriteLine("La cantidad de clientes es: " + cantidad);
			Console.WriteLine("\n====================================");
    }
}
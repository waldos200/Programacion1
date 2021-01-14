using System;
class Ejercicio8
{
    static void Main()
    {
        string seguir;
		int opcion;
		double compra=0, tax=0, total_tax=0, total_compra, tcompra=0;

        do
        {
            Console.WriteLine("\nTipo de producto\n\n1.Exclusivo\n2.Lujo\n3.Economico\n4.Accesible\n");
            Console.Write("\nIngrese opción: ");
			opcion = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Digite el total de la compra: $");
			compra=Convert.ToDouble(Console.ReadLine());
            
			switch (opcion)
        {
            case 1:
				tax=compra*0.30;
				total_compra=compra+tax;
				tcompra=tcompra+total_compra;
				total_tax=total_tax+tax;
			break;
			
            case 2:
				tax=compra*0.20;
				total_compra=compra+tax;
				tcompra=tcompra+total_compra;
				total_tax=total_tax+tax;
			break;
			
			case 3:
				tax=compra*0.10;
				total_compra=compra+tax;
				tcompra=tcompra+total_compra;
				total_tax=total_tax+tax;
			break;
			
			case 4:
				tax=compra*0.05;
				total_compra=compra+tax;
				tcompra=tcompra+total_compra;
				total_tax=total_tax+tax;
			break;
		default:
			Console.WriteLine("¡Opcion no existe!");
		break;
		}
            Console.Write("\nDesea continuar s/n ?");
            seguir = Console.ReadLine().ToLower();
       
            while (seguir != "s" && seguir != "n")
            {
                Console.Write("\nDesea continuar s/n ? ");
                seguir = Console.ReadLine().ToLower();
            }
        } while (seguir == "s");
			Console.WriteLine("\n====================================");
			Console.WriteLine("\nGracias por comprar en Almacen Guanacos");
			Console.WriteLine("\nEl impuesto total es de : $" + total_tax);
			Console.WriteLine("El total a pagar es: $" + tcompra);
			Console.WriteLine("\n====================================");
    }
}
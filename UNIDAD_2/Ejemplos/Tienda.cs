using System;
class Tienda{
    static void Main(string [] args){
        double total_compra;
        int cant_ciente;
        double cant_venta;
        string resp;
        cant_ciente = 0;
        cant_venta = 0;

        Console.Write("Desea introducir datos S/N: ");
        resp = Console.ReadLine().ToLower();
        while (resp == "s"){
            Console.Write("Digite el total de la compra: ");
            total_compra = Convert.ToDouble(Console.ReadLine());
            cant_venta = cant_venta + total_compra;
            cant_ciente++;
            Console.Write("Desea continual S/N: ");
            resp = Console.ReadLine().ToLower();
        }
        Console.WriteLine("La cantidad vendida es de: $" + cant_venta);
        Console.WriteLine("La cantidad de clientes atendidos: " + cant_ciente);
    }
}
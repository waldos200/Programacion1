using System;
class Tieda {
    static void Main(string [] args){
        double compra, total_venta = 0; // Acumulador
        int clientes=0;
        string resp = "s"; // Inicializando la variable
        while(resp.ToLower() == "s"){ // Valida la respuesta convirtiendola a munuscula
            Console.Write("Digite la compra: ");
            compra = Convert.ToDouble(Console.ReadLine());
            total_venta += compra; // total_venta = totalventa + compra
            clientes++; //clientes = clientes + 1 cantidad de cliente atendidos
            Console.Write("Desea continuar s/n: ");
            resp = Console.ReadLine();
        }
        Console.WriteLine("La cantidad vendida es de: $" + total_venta);
        Console.WriteLine("La cantidad de clientes fue de: " + clientes);
    }
}
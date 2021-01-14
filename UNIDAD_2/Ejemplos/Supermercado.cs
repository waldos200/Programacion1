using System;
class Supermercado{
    static void Main(string []args){
        int num, i;
        double desc, total_compra, total_pagar;
        i = 1;
        while (i <= 5){
            Console.Write("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el total de la compra: ");
            total_compra = Convert.ToDouble(Console.ReadLine());
            if (num < 50){
                desc = total_compra * 0.15;
            } else {
                desc = total_compra * 0.20;
            }
            total_pagar = total_compra - desc;

            Console.WriteLine("\nEl descuento es de: $", + desc);
            Console.WriteLine("\nEl total a pagar es: $", + total_pagar);
            i++;
        }
    }
}
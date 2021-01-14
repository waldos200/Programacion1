using System.Security.Cryptography;
using System;

class supermercado{
    static void Main (string [] args) {
        double compra;
        byte N_bola;

        Console.Write("Digite la cantidad de la compra: ");
        compra = Convert.ToDouble(Console.ReadLine());

        if(compra >= 25.00) {
            Console.Write("Digite el numero de la compra: ");
            N_bola = Convert.ToByte(Console.ReadLine());

            switch (N_bola) {
                case 1:
                    Console.WriteLine("Ganaste un shampoo");
                    break;
                case 2:
                    Console.WriteLine("Ganaste un paquete de 3 jabones");
                    break;
                case 3:
                    Console.WriteLine("Ganaste una pasta de dientes");
                    break;
                case 4:
                    Console.WriteLine("Ganaste una bolsa de deterjente");
                    break;
                case 5:
                    Console.WriteLine("Ganaste una caja de cereal de chocolate");
                    break;
                default:
                    Console.WriteLine("Numero de la bolita incorrecta");
                    break;
            }
        } else {
            Console.WriteLine("No participa en la tombola porque su compra es inferior a $25.00");
        }
    }
}
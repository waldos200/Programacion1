using System;

class Ejercicio2 {
    public static void Main (string [] args){
        int zona;
        double costo, peso_paquete;
        costo = 0;

        Console.WriteLine("===Zonas de Ubicación para envio===");
        Console.WriteLine("1. America del Norte\n2. America Cantral\n3. America del sur\n4. Europa\n5. Asia");
        Console.Write("\nIngrese la zona a la que va dirigido el paquete: ");
        zona = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el peso del paquete en libras: ");
        peso_paquete = Convert.ToDouble(Console.ReadLine());

        switch (zona) {
            case 1:
                costo = peso_paquete * 11;
                break;
            case 2:
                costo = peso_paquete * 10;
                break;
            case 3:
                costo = peso_paquete * 12;
                break;
            case 4:
                costo = peso_paquete * 24;
                break;
            case 5:
                costo = peso_paquete * 27;
                break;
            default:
                Console.WriteLine("Numero de xona o es correcto");
                break;
        }
        Console.WriteLine("El costo que deberá pagar es de: $" + costo);
    }
}
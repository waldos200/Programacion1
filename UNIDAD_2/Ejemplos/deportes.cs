using System;

class Deportes {
    static void Main(){
        int temp;

        Console.Write("Digite la temperatura en grados Fahrenheit: ");
        temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 10 && temp <= 32){
            Console.WriteLine("Puede practicar Esqui");
        } else if (temp > 32 && temp <= 70) {
            Console.WriteLine("Puede practicar Golf");
        } else if (temp > 70 && temp <= 85) {
            Console.WriteLine("Puede practicar Tenis");
        } else if (temp >= 85) {
            Console.WriteLine("Puede practicar Natación");
        } else {
            Console.WriteLine("No es aconsejable practicar deporte");
        }
    }
}
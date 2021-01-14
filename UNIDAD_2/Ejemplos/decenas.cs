using System;

class Decenas{
    static void Main(string [] args){
        string decenas= "";
        // Repetir decenas i=10 hasta 500...
        for (int i=10; i<=500; i+=10){
            // Formar una cadena con las decenas
            decenas = decenas + i.ToString() + ", ";
        }
        // Mostrar la cadena de las decenas
        Console.WriteLine(decenas);
    }
}
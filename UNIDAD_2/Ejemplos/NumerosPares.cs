using System;

class NumerosPares{
    static void Main(string [] args){
        int i;

        // Inicalizando el contador de la estructurra
        i=2;
        while (i<=100){
            Console.Write(i+", "); // Imprime horizontalmete y con comas 
            i+=2; // Se incrementa el contador de la estructura en 2
        }
    }
}
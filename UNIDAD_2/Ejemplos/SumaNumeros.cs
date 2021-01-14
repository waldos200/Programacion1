using System;

class SumaNumeros{
    static void Main (string [] args){
        int i, num, suma;

        // inicializamos el contador de la estructura y acumulador
        i = 1;
        suma = 0;

        while (i <= 10){
            Console.Write("digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            suma = suma + num; // acumulador que suma los numeros 
            i++; // se incrementa el contador de la estructura
        }
        // imprimiendo el resultado
        Console.WriteLine("La suma es: {0}", suma);
        // tambien se puede imprimir sin formato
        Console.WriteLine("La suma es: " + suma);
    }
}
using System;

class NumerosWhile{
    static void Main(string [] args){
        int i; // Variable contador
        i = 1; // Inicializacion del contador
        /* Cuando se inicializa en 1 el contador en la condicion
        se debe inclur el signo =, pero si se inicializa con 0
        entonces no se escribe el = */
        while (i <= 10){
            Console.WriteLine(i); // Imprime en forma vertical
            // si desea que imprima de orma horizontal
            // Console.Write(i + " ");
            i++; // Incremento del cotador en 1
        }
    }
}
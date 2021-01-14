using System;
class centinela{
    static void Main(string []args){
        int numero, suma, cont;

        suma = 0;
        cont = 0;

        Console.Write("Digite un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());
        while(numero != 0){
            suma = suma + numero;
            cont++;
            Console.Write("Si desea continuar digite un numero diferente de 0: ");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("La suma es de: " + suma);
        Console.WriteLine("Cantidad de numeros leidos: " + cont);
    }
}
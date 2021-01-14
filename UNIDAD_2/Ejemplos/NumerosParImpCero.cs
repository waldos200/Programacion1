using System;

class NumerosParImpCero{
    static void Main(string []args){
        int i, numero, cont_par, cont_imp, cont_cero;

        i = 1;
        cont_par = 0;
        cont_imp = 0;
        cont_cero = 0;

        while (i <= 10){
            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 0){
                cont_cero++;
            } else if (numero % 2 == 0){
                cont_par++;
            } else {
                cont_imp++;
            }
            i++;
        }
        Console.WriteLine("\nLa cantidad de ceros es de: " + cont_cero +
                          "\nLa cantidad de pares son: " + cont_par +
                          "\nLa cantidad de impares son: " + cont_imp);
    }
}
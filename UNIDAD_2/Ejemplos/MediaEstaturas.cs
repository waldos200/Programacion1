using System;
class MediaEstaturas{
    static void Main(string [] args){
        string resp, sexo;
        double altura, media_h, media_m, acumulador_h, acumulador_m;
        int contador_h, contador_m;

        acumulador_h = 0;
        acumulador_m = 0;
        contador_h = 0;
        contador_m = 0;

        Console.Write("Desea pedir datos S/N: ");
        resp = Console.ReadLine().ToLower();

        while (resp == "s"){
            Console.Write("Ingrese el sexo masculino (m) o femenino (f): ");
            sexo = Console.Write("Ingrese la estatura en metros: ");
            altura = Convert.ToDouble(Console.ReadLine());
            if (sexo == "m"){
                acumulador_h = acumulador_h + altura;
                contador_h++;
            } else {
                acumulador_m = acumulador_m + altura;
                contador_m++;
            }
            Console.Write("Desea edir mas datos S/N: ");
            resp = Console.ReadLine().ToLower();
        }
        Console.WriteLine("\nMedia de estatura de hombres y mujeres");
        Console.WriteLine("============================================");
        if (contador_h > 0){
            media_h = acumulador_h / contador_h;
            Console.WriteLine("\nMedia de estatura de hombres: " + media_h);
        } else {
            Console.WriteLine("Media de estatura de hombres=0. No hay datos del sexo masculino");
        }

        if (contador_m > 0){
            media_m = acumulador_m / contador_m;
            Console.WriteLine("Media de estatura de mujeres: " + media_m);
        } else {
            Console.WriteLine("Media de estatura de mujeres=0. No hay datos del sexo femenino");
        }
    }
}
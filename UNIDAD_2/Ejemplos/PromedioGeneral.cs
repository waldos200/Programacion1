using System;
class PromedioGeneral{
    static void Main(string [] args){
        double nota, promedio, suma; // Suma es un acumulador
        int i, aprob, reprob; // Contadores
        aprob = 0;
        reprob = 0;
        suma = 0; // Inicializando los contadores y acumulador
        i = 1;
        while (i<=25){
            Console.Write("Digite la nota del alumo {0}: ", i);
            nota = Convert.ToDouble(Console.ReadLine());
            suma = suma + nota;
            if (nota >= 6.0){
                aprob = aprob + 1;
            } else {
                reprob = reprob + 1;
            }
            i++;
        }
        promedio = suma / 25;
        Console.WriteLine("\n================Resultado================");
        Console.WriteLine("Cantidad de aprobados: " + aprob);
        Console.WriteLine("Cantidad de reprobados: " + reprob);
        Console.WriteLine("El promedio general: " + promedio);
    }
}
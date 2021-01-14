using System;
class numeros{
    static void Main(string [] args){
        float precio = 100f, desc=0;
        int opcion;
        Console.Write("ingrese la opcion: ");
        opcion= Convert.ToInt32(Console.ReadLine());
        switch(opcion){
            case "1":
            case "2":
            case "3":
                desc = 0.10f * precio;
                break;
            case "4":
            case "5":
            case "6":
                desc = 0.15f * precio;
                break;
            default:
                desc = 0;
                break;
        }
        Console.Write("descuento: $ " + desc);
    }
}
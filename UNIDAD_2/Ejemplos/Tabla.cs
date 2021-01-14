using System;
class Tabla{
    static void Main(string [] args){
        int tabla, i;
        string resp;

        resp = "s";

        while(resp.ToLower() == "s"){
            Console.Write("Digite el numero de tabla que desea: ");
            tabla = Convert.ToInt32(Console.ReadLine());
            for(i=1; i<=10; i++){
                Console.WriteLine(tabala + " x " + i + " = " + tabla*i);
            }
            Console.Write("Desea continuar con otra tabla s/n: ");
            resp =Console.ReadLine();
        }
    }
}
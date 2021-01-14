using System;
class Tablas{
    static void Main(string [] args){
        int cont, tabla;
        string resp;
        cont = 1;
        Console.Write("Desea introducir una tabla s/n: ");
        resp = Console.ReadLine().ToLower();

        // Lazo externo controlado por el usuario
        while(resp == "s"){
            Console.Write("Digite un numero de tabla: ");
            tabla = Convert.ToInt32(Console.ReadLine());
            // Lazo interno controlado por contador
            while(cont <= 10){
                Console.WriteLine(tabla + " x " + cont + " = " + tabla*cont);
                cont++;
            }
            Console.Write("Desea contiuar con otra tabla s/n: ");
            resp = Console.ReadLine().ToLower();
            cont = 1; // Se debe inicializar el contador en 1
        }
    }
}
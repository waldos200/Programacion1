using System;
class Menu{
    static void Main(string[] args){
        int opcion;
        double area, radio, bas, altura, lado;

        area = 0;

        Console.WriteLine("=====================Menu de opciones=====================");
        Console.WriteLine("1. Area del triangulo \n2. Area del rectangulo");
        Console.WriteLine("3. Area del circulo \n4. Salir");
        Console.Write("Digite una opcion: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        while (opcion != 4){

            switch (opcion){
                case 1:
                    Console.Write("Digite la base: ");
                    bas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite la altura: ");
                    altura = Convert.ToDouble(Console.ReadLine());
                    area = bas * altura / 2;
                    Console.WriteLine("\nEl area del triangulo es: " + area);
                    break;
                case 2:
                    Console.Write("Digite el valor del lado: ");
                    lado = Convert.ToDouble(Console.ReadLine());
                    area = lado * lado;
                    Console.WriteLine("\nEl area del cuadrado es: " + area);
                    break;
                case 3:
                    Console.Write("Digite el radio: ");
                    radio = Convert.ToDouble(Console.ReadLine());
                    area = 3.1416 * radio * radio;
                    Console.WriteLine("\nEl area del circulo es: " + area);
                    break;
                default:
                    Console.WriteLine("Opcion no existente!!");
                    break;
            }
            Console.Write("\nDigite otra opcion o 4 para salir: ");
            opcion = Convert.ToInt32(Console.ReadLine());
        }
    }
}
using System;

class Parcial1{
    static void Main(string [] args){
        double nota1, nota2, nota3, promedio;
        string nombre, apellido;

        Console.Write("Digite el nombre del alumno: ");
        nombre = Console.ReadLine();
        Console.Write("Digite el apellido del alumno: ");
        apellido = Console.ReadLine();
        Console.Write("Digite la primera nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine()) * 0.30;
        Console.Write("Digite la segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine()) * 0.30;
        Console.Write("Digite la tercera nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine()) * 0.40;

        promedio = nota1 + nota2 + nota3;

        Console.WriteLine("Nombre: {0} {1} \nPromedio: {2} ", nombre, apellido, promedio);

        if (promedio >= 6.0){
            Console.Write("\"Aprobado\"");
        } else {
            Console.Write("\"Reprobado\"");
        }
    }
}
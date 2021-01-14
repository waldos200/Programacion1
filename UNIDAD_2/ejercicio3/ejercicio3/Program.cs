using System;

namespace ejercicio3
{
    class AreaTriangulo
    {
        static void Main(string[] args)
        {
            // Declaracion de variables de tipo double
            double bas, altura, area;

            //captura de datos
            Console.Write("Digite la base: ");
            bas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            // Calculo del area del triangulo
            area = bas * altura / 2;

            //Salida de resultados con formato
            Console.WriteLine("El area del trinagulo con base {0} y altura {1} es de: {2} ", bas, altura, area);
        }
    }
}

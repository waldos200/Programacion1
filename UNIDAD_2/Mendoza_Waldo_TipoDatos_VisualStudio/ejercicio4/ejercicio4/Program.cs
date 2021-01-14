using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros, centimetros;

            Console.WriteLine("Digite la cantidad de metros quiere pasar a centimetros:");
            metros = Convert.ToDouble(Console.ReadLine());

            centimetros = metros / 0.01;

            Console.WriteLine("Esta es la conversion de {0} metros a cetimetros: " + centimetros, metros);
        }
    }
}

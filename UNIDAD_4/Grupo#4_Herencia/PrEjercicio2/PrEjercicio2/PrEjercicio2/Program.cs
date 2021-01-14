using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipoTrans;
            int cantPasajeros;
            string marca;
            string modelo;
            int motor;

            Console.WriteLine("\n\n\tBIENVENIDO AL PROGRAMA DE MEDIOS DE TRANSPORTE");
            Console.WriteLine("\n\tInfo: \'Usa siempre el cinturon de seguridad.\'");


            Console.Write("\n\n\tDigite el tipo de transporte: ");
            tipoTrans = Console.ReadLine();

            Console.Write("\tDigite la cantidad de pasajeros: ");
            cantPasajeros = Convert.ToInt32(Console.ReadLine());

            Console.Write("\tDigite la marca: ");
            marca = Console.ReadLine();

            Console.Write("\tDigite el modelo: ");
            modelo = Console.ReadLine();

            Console.Write("\tDigite el numero de motor: ");
            motor = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\n\t\tDETALLES DEL VEHICULO");

            Automovil obj1 = new Automovil(marca, modelo, motor, tipoTrans, cantPasajeros);

            obj1.Mostrar();
            Console.ReadKey();
  
        }
    }
}

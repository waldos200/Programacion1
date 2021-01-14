using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_Estudiantes
{
    class PromedioParametros
    {
        public void MostrarInfo(string carnet, string nombre, string apellido)
        {
            Console.WriteLine("Carnet: " + carnet + "\nNombre: " + nombre + " " + apellido);
        }
        public double Promedio(double n1, double n2, double n3, double n4, double n5)
        {
            return (n1 + n2 + n3 + n4 + n5) / 5;
        }
    }
}

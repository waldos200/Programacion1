using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mendoza_Waldo_p3
{
    class Universidad
    {
        public string categoria;
        private int NumeroDeAsignaturas = 0;
        public double totalPago = 0;

        public Universidad()
        {
            Console.WriteLine("====Bienvenidos estudiantes universitarios====");
        }

        public void Datos()
        {
            if(categoria == "A")
            {
                totalPago = 15 * NumeroDeAsignaturas;
                Console.WriteLine("Este es el total a pagar: " + totalPago);
            }
            else if (categoria == "N")
            {
                totalPago = 20 * NumeroDeAsignaturas;
                Console.WriteLine("Este es el total a pagar: " + totalPago);
            }
            else
            {
                Console.WriteLine("No existe esta opcion");
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("\nEsta es la cateoria del estudiante: {0}", categoria);
            Console.WriteLine("Este es el numero de materias que llevara el estudiante: {0}", NumeroDeAsignaturas);
            Datos();
        }

        public int num
        {
            get { return NumeroDeAsignaturas = 0; }
            set 
            {
                if (value > 0)
                    NumeroDeAsignaturas = value;
                else
                    Console.WriteLine("Error, la nota debe ser mayor a cero");
            }
        }
    }
}

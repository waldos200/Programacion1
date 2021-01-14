using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio2
{
    class Transporte
    {
        public string tipoTrans;
        public int cantPasajeros;

        public Transporte(string tipoTrans, int cantPasajeros)
        {
            this.tipoTrans = tipoTrans;
            this.cantPasajeros = cantPasajeros;
        }

        public void Mostrar ()
        {
        Console.Write("\n\n\t\tMedios de Transporte\n\n\t\tTipo de transporte: {0}\n\t\tCantidad de pasajeros:\t{1}", tipoTrans, cantPasajeros);
        }
    }
}

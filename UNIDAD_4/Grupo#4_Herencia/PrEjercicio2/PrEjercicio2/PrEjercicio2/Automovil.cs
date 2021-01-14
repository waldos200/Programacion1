using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrEjercicio2
{
    class Automovil:Transporte
    {
        public string marca;
        public string modelo;
        public int motor;

        public Automovil(string marca, string modelo, int motor, string tipoTrans, int cantPasajeros) : base(tipoTrans, cantPasajeros)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.motor = motor;
        }
        new public void Mostrar()
        {
            base.Mostrar();
            Console.Write("\n\t\tMarca: {0}\n\t\tModelo: {1}\n\t\tMotor: {2}", marca, modelo, motor);
        }
    }
}

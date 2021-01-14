using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    //En una clase llamada Estudiante se tienen dos métodos y una variable, la variable se llama carrera y es privada.
    //  a.El primer método se llamará estudiar y tendrá un parámetro, la función de éste será mostrar en pantalla el
    //mensaje “Yo estudio” y concatenar la variable que recibirá en el parámetro el cual será capturado desde
    //teclado.Ejemplo del mensaje “Yo estudio Ingeniería en Sistemas”.
    //b.La función del segundo método será capturar el valor de la variable desde teclado.
    //c.Cree un constructor por omisión, el cual se encargará de mostrar el mensaje “Me gusta estudiar”.
    //Cree la clase que contiene el método Main e invoque los métodos.
    class Estudiante
    {
        //En una clase llamada Estudiante se tienen dos métodos y una variable, la variable se llama carrera y es privada.
        private string carrera;
        public Estudiante()
        {
            //c.Cree un constructor por omisión, el cual se encargará de mostrar el mensaje “Me gusta estudiar”.
            Console.Write("\n\n\tMe gusta estudiar");
        }


        public void Estudiar(string carrera)
        {
            //  a.El primer método se llamará estudiar y tendrá un parámetro, la función de éste será mostrar en pantalla el
            //mensaje “Yo estudio” y concatenar la variable que recibirá en el parámetro el cual será capturado desde
            //teclado.Ejemplo del mensaje “Yo estudio Ingeniería en Sistemas”.

            Console.Write("\n\tYo estudio {0}", carrera);
            this.carrera = carrera;
        }

        public void Captura()
        {
            //b.La función del segundo método será capturar el valor de la variable desde teclado.
            Console.Write("\n\tIngrese el nombre de la carrera : ");
            carrera = Console.ReadLine();
        }

        public string NCarrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

    }
}

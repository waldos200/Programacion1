using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo3
{
    class Rect
    {
        public int ancho, alto;

        public Rect(int ancho, int alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
        public int Area()
        {
            return this.alto * this.ancho;
        }
    }
}

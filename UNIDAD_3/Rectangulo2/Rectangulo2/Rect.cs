using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo2
{
    class Rect
    {
        public int Ancho;
        public int Alto;

        public Rect(int an, int al)
        {
            this.Ancho = an;
            this.Alto = al;
        }

        public int Area()
        {
            return this.Alto * this.Ancho;
        }
    }
}

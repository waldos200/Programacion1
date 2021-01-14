using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    class Rect
    {
        public int Ancho;
        public int Alto;

        public Rect(int an, int al)
        {
            Ancho = an;
            Alto = al;
        }

        public int Area()
        {
            return Alto * Ancho;
        }
    }
}

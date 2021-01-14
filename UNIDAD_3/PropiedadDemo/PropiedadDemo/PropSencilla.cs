using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadDemo
{
    class PropSencilla
    {
        private int prop; // Campo a ser administrado por MiProp
        public PropSencilla()
        {
            prop = 0;
        }

        /* Esta es la propiedad que proporciona soporte de acceso
         a la propiedad de instancia privada prop.
        Permite valores positivos solamente */
        public int MiProp
        {
            get
            {
                return prop;
            }
            set
            {
                if (value >= 0) prop = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vela
{
    class Objeto
    {
        protected int x, y, ancho, largo;
        public Objeto ()
        {
            ancho = 10;
            largo = 10;
        }

        public Boolean interseccion (Objeto obj)
        {
            int difX = Math.Abs(this.x - obj.x);
            int difY = Math.Abs(this.y - obj.y);

            if(difX >= 0 && difX < ancho && difY >= 0 && difY < largo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vela
{
    class vela : Objeto
    {
        int puntaje;
        string nombre;
        int velocidad;
        int acX;
        int acY;
        
        public vela (int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public void dibujar (Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Blue),this.x, this.y,this.ancho,this.largo);
        }

        public void setXY(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public int verX ()
        {
            return this.x;
        }
        public int verY()
        {
            return this.y;  
        }
    }
}

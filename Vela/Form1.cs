using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vela
{
    public partial class Form1 : Form
    {
        Graphics g;
        vela objvela;

        int xdir= 0, ydir = 0;
        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            objvela = new vela(10, 10);
        }
        public void movimiento ()
        {

        }
        private void canvas_Click(object sender, EventArgs e)
        {

        }

        private void bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            objvela.dibujar(g);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}

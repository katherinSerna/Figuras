using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        enum TipoFigura {Rectangulo, Circulo}
        private TipoFigura figura_actual;
        
        private List<Figura> rectangulos;
        public Form1()
        {

            figura_actual = TipoFigura.Circulo;
          //  figura_actual = TipoFigura.Rectangulo;
            rectangulos = new List<Figura>();
            InitializeComponent();
            circuloToolStripMenuItem.Checked = true;

            //  circuloToolStripMenuItem

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (MouseButtons.Right == e.Button)
            {

                contextMenuStrip1.Show(this, e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (figura_actual == TipoFigura.Circulo)
                {
                    Circulo c = new Circulo(e.X, e.Y);
                    c.Draw(this);
                    rectangulos.Add(c);


                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {

                    Rectangulo r = new Rectangulo(e.X, e.Y);
                    r.Draw(this);
                    rectangulos.Add(r);



                }

            }
        
           /* else if (e.Button == MouseButtons.Right)
            {

               // this.contextMenuStrip1.Show(this, new Point(e.X, e.Y));
                contextMenuStrip1.Show(this, e.X, e.Y);

            }*/
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /* foreach (Figura f in figuras)
             {
                 f.Dibuja(this);

             }*/

            foreach (Figura r in rectangulos)
                r.Draw(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(this, e.X, e.Y);

        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // figura_actual = TipoFigura.Rectangulo;
            this.rectanguloToolStripMenuItem.Checked = true;
            this.circuloToolStripMenuItem.Checked = false;
            figura_actual = TipoFigura.Rectangulo;
        }

        private void figuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
             figura_actual = TipoFigura.Circulo;
            this.circuloToolStripMenuItem.Checked = true;
            this.rectanguloToolStripMenuItem.Checked = false;

        }
    }
}
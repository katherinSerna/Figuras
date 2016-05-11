using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    public partial class Form1 : Form
    {
        public Color brocha;
        public Color pluma;
        enum TipoFigura  {Rectangulo, Circulo, linea};

        private TipoFigura figura_actual; 
        private List<Figura> rectangulos;
        

        public Form1()
        {
            figura_actual = TipoFigura.Circulo;
           
            rectangulos = new List<Figura>();
            InitializeComponent();
            circuloToolStripMenuItem.Checked = true;
        }

       public void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                
                contextMenuStrip1.Show(this, e.X,e.Y);
            }
            else if (MouseButtons.Left == e.Button)
            {
               
                if (figura_actual == TipoFigura.Circulo)
                     {
                    //   Circulo c = new Circulo(new SolidBrush(brocha), new Pen(pluma), e.X, e.Y,10,10);
                    Circulo c = new Circulo(e.X, e.Y, new SolidBrush (brocha));

                    c.Draw(this);
                    rectangulos.Add(c);


                }
                else if (figura_actual == TipoFigura.Rectangulo)
                {
                    //  Rectangulo r = new Rectangulo(e.X, e.Y, new SolidBrush(brocha), new Pen(pluma, 1),10,10);
                    Rectangulo r = new Rectangulo(e.X, e.Y, new SolidBrush(brocha));
                    r.Draw(this);
                    rectangulos.Add(r);


                }
                else if (figura_actual == TipoFigura.linea)
                {
                    //  Rectangulo r = new Rectangulo(e.X, e.Y, new SolidBrush(brocha), new Pen(pluma, 1),10,10);
                   
                    Linea l = new Linea(e.X, e.Y, new SolidBrush(brocha));
                    l.Draw(this);
                    rectangulos.Add(l);

                }
            }
          

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Polimorfismo
           foreach (Figura r in rectangulos)
               r.Draw(this);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            figura_actual = TipoFigura.Rectangulo;
            Console.Beep();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.circuloToolStripMenuItem.Checked = true;
            figura_actual = TipoFigura.Circulo;
            Console.Beep();
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectangulos.Sort();
            rectangulos.Reverse();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            // e.Graphics.Clear(Color.Teal);
            this.CreateGraphics().Clear(Form1.ActiveForm.BackColor);
            Console.Beep();

        }

        private void beepToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Console.Beep();
        

        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brocha = Color.Black;
            this.negroToolStripMenuItem.Checked = true;
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brocha = Color.Red;
            this.rojoToolStripMenuItem.Checked = true;
  
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brocha = Color.Blue;
            this.azulToolStripMenuItem.Checked = true;

        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brocha = Color.Green;
            this.verdeToolStripMenuItem.Checked = true;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brocha = Color.Yellow;        
            this.verdeToolStripMenuItem.Checked = true;
        }

        private void figuraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rectanguloToolStripMenuItem.Checked = true;
            figura_actual = TipoFigura.linea;
            Console.Beep();
        }

        private void rojoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void verdeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void amarilloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void limpiarPantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Form1.ActiveForm.BackColor);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void blancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
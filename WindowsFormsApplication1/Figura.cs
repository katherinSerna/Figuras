using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    abstract class Figura : IComparable
    {
        protected int X;
        protected int Y;
        protected Pen pluma;
        protected int ancho;
        protected int largo;
        protected Color color;
        protected SolidBrush brocha;

        public Figura(int x, int y, SolidBrush broch)
        {
            X = x;
            Y = y;

            brocha = new SolidBrush(Color.Yellow);
            pluma = new Pen(Color.Black, 5);
            this.brocha = broch;
            Random rnd = new Random();
            ancho = rnd.Next(10, 60);
            largo = ancho;
        }

        public abstract void Draw(Form f);

        public int CompareTo(object obj)
        {

            return this.largo.CompareTo(((Figura)obj).largo);
        }

        /*   public Figura(int x, int y, SolidBrush bro, Pen plu, int anc, int lar)
           {
               brocha = bro;
               this.brocha = bro;
               pluma = plu;
               this.pluma = plu;
               X = x;
               Y = y;
               ancho= anc;
               this.ancho = anc;
               largo = lar;
               this.largo = lar;
           }*/
    }

   

    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y, SolidBrush broch) : base(x, y, broch)
        {
        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
            g.FillRectangle(brocha, this.X, this.Y, ancho, largo);
        }

    }

    class Circulo : Figura
    {
        public Circulo(int x, int y, SolidBrush broch) : base(x, y, broch)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
            g.FillEllipse(brocha, this.X, this.Y, ancho, largo);
        }



    }


    class Linea : Figura
    {
        public Linea(int x, int y, SolidBrush broch) : base(x, y, broch)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawLine(pluma, this.X, this.Y, ancho, largo);
            
        }

    }
}
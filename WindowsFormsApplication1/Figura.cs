

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    abstract class Figura
    {
        Random aleatorio = new Random();

        public int X, Y;
        public Pen pluma;
        public Brush brocha;
        public Color color_relleno;
        public int ancho, largo;

        public Figura(int x, int y)
        {
            X = x;
            Y = y;
            pluma = new Pen(Color.Red, 2);
            ancho = aleatorio.Next(1,100);
            largo = aleatorio.Next(1,100);


        }

        public abstract void Dibuja(Form f);


    }
    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y) : base(x, y)
        {

        }

        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);



        }


    }


    class Circulo : Figura
    {
        public Circulo(int x, int y) : base(x, y)
        {

        }

        public override void Dibuja(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, X, Y, ancho, largo);
            
        }


    }

}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SolidBrush Brush;
        Circle circle;
        Square square;
        Rhomb rhomb;
        public bool clicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (clicked == false)
            {
                clicked = true;
                CircleDraw();
                circle.DrawBlack();

            }
            else
            {
                CircleDraw();
                circle.HideDrawingBackGround();
                clicked = false;
                circle = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                SquareDraw();
                square.DrawBlack();

            }
            else
            {
                SquareDraw();
                square.HideDrawingBackGround();
                clicked = false;
                square = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clicked == false)
            {
                clicked = true;
                RhombDraw();
                rhomb.DrawBlack();

            }
            else
            {
                RhombDraw();
                rhomb.HideDrawingBackGround();
                clicked = false;
                rhomb = null;
            }
        }
        public void CircleDraw()
        {

            circle = new Circle(70, 80, 117.3);
            circle.DrawBlack();
        }
        public void SquareDraw()
        {
            square = new Square(56);
            square.DrawBlack();
        }
        public void RhombDraw()
        {
            rhomb = new Rhomb(56.3, 23.2);
            rhomb.DrawBlack();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (circle != null)
            {
                circle.MoveRight();
            }
            else if (square != null)
            {
                square.MoveRight();
            }
            else if (rhomb != null)
            {
                rhomb.MoveRight();
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {




            if (circle != null)
            {
                Brush = new SolidBrush(circle.Color);
                e.Graphics.FillEllipse(Brush, (float)circle.X, (float)circle.Y, (float)circle.R, (float)circle.R);
            }
            else if (square != null)
            {
                Brush = new SolidBrush(square.Color);
                e.Graphics.FillRectangle(Brush, (float)square.X, (float)square.Y, (float)square.side, (float)square.side);
            }
            else if (rhomb != null)
            {
                Brush = new SolidBrush(rhomb.Color);
                using (GraphicsPath myPath = new GraphicsPath())
                {
                    myPath.AddLines(new[]
                        {
                           new Point(0+ Convert.ToInt32(rhomb.X), Convert.ToInt32(rhomb.hor / 2.0)),
                           new Point(Convert.ToInt32(rhomb.vert   / 2)+ Convert.ToInt32(rhomb.X), 0),
                           new Point(Convert.ToInt32(rhomb.vert+ rhomb.X) , Convert.ToInt32(rhomb.hor / 2.0)),
                           new Point(Convert.ToInt32(rhomb.vert  / 2)+ Convert.ToInt32(rhomb.X), Convert.ToInt32(rhomb.hor))
                    });
                    using (Brush)

                        e.Graphics.FillPath(Brush, myPath);

                }
            }

        }

    }
}

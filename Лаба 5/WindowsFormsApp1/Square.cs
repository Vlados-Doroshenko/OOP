using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Square : Figure
    {
        private double sideLength;

        public double side
        {
            get
            {
                return sideLength;
            }

            set
            {
                sideLength = side;
            }
        }

        public Square() { }

        public Square(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public Square(double X, double Y, double sideLength)
        {
            this.X = X;
            this.Y = Y;
            this.sideLength = sideLength;
        }

        public override void DrawBlack()
        {
            Color = Color.Black;
        }
        public override void HideDrawingBackGround()
        {
            Color = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Circle : Figure
    {
        private double radius;

        public double R
        {
            get
            {
                return radius;
            }

            set
            {
                radius = R;
            }
        }

        public Circle() { }

        public Circle(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Circle(double radius) 
        { 
            this.radius = radius; 
        }

        public Circle(double X, double Y, double radius)
        {
            this.X = X;
            this.Y = Y;
            this.radius = radius;
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

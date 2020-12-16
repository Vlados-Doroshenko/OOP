using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Figure
    {
        private double x;
        private double y;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public double X
        {
            get {
                return x;
            }
            set
            {
                x = X;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = Y;
            }
        }

        public void MoveRight()
        {
            if (x == 550) { x = 0; }

            x += 10;
            System.Threading.Thread.Sleep(100);
        }

        public Color Color { get; set; }
       
    }
}

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

        public Color Color { get; set; }

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
            HideDrawingBackGround();
            DrawBlack();
            System.Threading.Thread.Sleep(100);                 
            x++;
        }



    }
}

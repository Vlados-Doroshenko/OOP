using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rhomb : Figure
    {
        private double horDiagLen;
        private double vertDiagLen;

        public double hor
        {
            get
            {
                return horDiagLen;
            }

            set
            {
                horDiagLen = hor;
            }
        }

        public double vert
        {
            get
            {
                return vertDiagLen;
            }

            set
            {
                vertDiagLen = vert;
            }
        }

        public Rhomb() { }
        public Rhomb(double hor, double vert)
        {
            this.horDiagLen = hor;
            this.vertDiagLen = vert;
        }
        public Rhomb(double x, double y, double hor, double vert)
        {
            this.X = x;
            this.Y = y;
            this.horDiagLen = hor;
            this.vertDiagLen = vert;
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

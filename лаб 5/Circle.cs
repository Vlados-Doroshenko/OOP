using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Circle : Figure
    {

        double radius { get; set; }
        public Circle() { }
        public Circle(double radius) { this.radius = radius; }
        public Circle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Circle(int x, int y, double radius)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawEllipse(Pens.Black, x, y, (int)radius, (int)radius);
            }
        }
        public override void HideDrawingBackGround(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawEllipse(Pens.White, x, y, (int)radius, (int)radius);

            }
        }
    }
}

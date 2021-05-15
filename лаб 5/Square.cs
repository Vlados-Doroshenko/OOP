using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Square : Figure
    {
        private double side { get; set; }
        public Square() { }
        public Square(int sideLength) { this.side = sideLength; }
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Square(int x, int y, double side)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }
        public override void DrawBlack(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(Pens.Black, x, y, (int)side, (int)side);
            }
        }
        public override void HideDrawingBackGround(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                g.DrawRectangle(Pens.White, x, y, (int)side, (int)side);
            }
        }
    }
}

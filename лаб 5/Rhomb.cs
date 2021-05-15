using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Rhomb : Figure
    {
        private double horDiag { get; set; }

        private double vertDiag { get; set; }

        public Rhomb() { }
        public Rhomb(double horDiagLen, double vertDiagLen)
        {
            this.horDiag = horDiagLen;
            this.vertDiag = vertDiagLen;
        }
        public Rhomb(int x, int y, double horDiagLen, double vertDiagLen)
        {
            this.x = x;
            this.y = y;
            this.horDiag = horDiagLen;
            this.vertDiag = vertDiagLen;
        }

        public override void DrawBlack(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                Rectangle rec = new Rectangle(x, y, (int)horDiag, (int)vertDiag);
                using (Matrix matrix = new Matrix())
                {
                    matrix.RotateAt(45, new PointF(rec.Left + (rec.Width / 2), rec.Top + (rec.Height / 2)));
                    g.Transform = matrix;
                    g.DrawRectangle(Pens.Black, rec);
                }
            }
        }
        public override void HideDrawingBackGround(PictureBox p)
        {
            using (var g = Graphics.FromImage(p.Image))
            {
                Rectangle rec = new Rectangle(x, y, (int)horDiag, (int)vertDiag);
                using (Matrix matrix = new Matrix())
                {
                    matrix.RotateAt(45, new PointF(rec.Left + (rec.Width / 2), rec.Top + (rec.Height / 2)));
                    g.Transform = matrix;
                    g.DrawRectangle(Pens.White, rec);

                }
            }
        }
    }
}

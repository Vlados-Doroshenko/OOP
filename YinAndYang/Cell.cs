using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace YinAndYang
{
    abstract class  Cell
    {
        public int size;
        public Label square = new Label();
        public int x, y;

        public Cell(int size, Point position,int i, int j)
        {
            this.size = size;
            this.square.BackColor = Color.White;
            this.square.Location = position;
            this.square.Size = new Size(size, size);
            this.x = j;
            this.y = i;
        }

        public int Size
        {
            get { return size; }
            set { this.size = value; }
        }

        public int X
        {
            get { return x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return y; }
            set { this.y = value; }
        }

        public Cell(Cell cell)
        {

        }
        public abstract void Check(Cell[,] Map, ref int[,] temp);               
    }
}

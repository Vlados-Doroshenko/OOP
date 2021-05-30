using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace YinAndYang
{
    class WhiteCell : Cell
    {                       
        public WhiteCell(int size, Point position, int i,int j) : base(size, position, i, j)
        {
            this.size = size;           
            this.square.Location = position;
            this.square.Size = new Size(size, size);
            this.x = j;
            this.y = i;
            this.square.BackColor = Color.White;

        }
        public WhiteCell(Cell cell) : base(cell)
        {
            this.square = cell.square;
            square.BackColor = Color.White;
            this.square.Location = cell.square.Location;
            this.square.Size = cell.square.Size;
            this.x = cell.x;
            this.y = cell.y;
        }

        public override void Check(Cell[,] Map, ref int[,] temp)
        {
            int b = 0;
            int r = 0;
            for (int k = x - 1; k <= x + 1; k++)
            {
                if (k < 0 | k > Map.GetLength(0) - 1) continue;
                for (int h = y - 1; h <= y + 1; h++)
                {
                    if (h < 0 | h > Map.GetLength(1) - 1) continue;

                    if (Map[k, h].square.BackColor == Color.Black) b++;
                    if (Map[k, h].square.BackColor == Color.Red) r++;
                }
            }
            if (b >= 2 & b < 4)
            {
                temp[x, y] = 1;
            }
            else
            if (r >= 2 & r < 4)
            {
                temp[x, y] = 2;
            }
            else
            {
                temp[x, y] = 0;
            }
        }
    }
}

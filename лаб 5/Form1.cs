using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Figure figure;
        public Form1()
        {
            InitializeComponent();
            Bitmap b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            numericUpDown1.Value = 100;
        }

        private async void circle_Click(object sender, EventArgs e)
        {
            figure = new Circle(2, 80, 56);
            await Task.Factory.StartNew(start_thread_parse);
        }

        private async void square_Click(object sender, EventArgs e)
        {
            figure = new Square(56);
            await Task.Factory.StartNew(start_thread_parse);
        }

        private async void rhomb_Click(object sender, EventArgs e)
        {
            figure = new Rhomb(10, 180, 50, 50);
            await Task.Factory.StartNew(start_thread_parse);
        }

        private void start_thread_parse()
        {
            while (true)
            {
                figure.MoveRight(pictureBox1);
                Thread.Sleep(Convert.ToInt32(numericUpDown1.Value));
                this.Invoke(new MethodInvoker(delegate {
                    pictureBox1.Refresh();
                }));
            }
        }
    }
}

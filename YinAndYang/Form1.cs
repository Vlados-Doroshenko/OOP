using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YinAndYang
{
    public partial class Form1 : Form
    {
        int size = 30;
        public int field;
        Cell[,] Map;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            field = Convert.ToInt32(numericUpDown1.Text);

            CreateMap();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void CreateMap()
        {
            Map = new Cell[field, field];
            for (int i = 0; i < field; i++)
            {
                for (int j = 0; j < field; j++)
                {
                    Point loc = new Point(20 + (size + 10) * j, 90 + (size + 10) * i);
                    Map[i, j] = new WhiteCell(size, loc, i, j);
                    Controls.Add(Map[i, j].square);

                }
            }
            int[,] temp = new int[field, field];
            int rnd;
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    rnd = new Random().Next(0, 2);
                    temp[i, j] = rnd;
                }
            }
        }

        public void FirstUpdate()
        {
            int[,] temp = new int[field, field];
            Random rand = new Random();
            for(int i = 0; i < temp.GetLength(0); i++)
            {
                for(int j = 0;j < temp.GetLength(1); j++)
                {
                    temp[i, j] = rand.Next(0, 3);
                }
            }
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (temp[i, j] == 0)
                    {
                        Map[i, j] = new WhiteCell(Map[i, j]);                        
                    }
                    if (temp[i, j] == 2)
                    {
                        Map[i, j] = new RedCell(Map[i, j]);
                    }
                    if (temp[i, j] == 1)
                    {
                        Map[i, j] = new BlackCell(Map[i, j]);                        
                        temp[i, j] = 0;
                    }

                }
            }
        }

        public void UpdateMap()
        {
            int[,] temp = new int[field, field];            
            label1.Text = "Red Death: " + RedCell.redDies;
            label2.Text = "Black Death: " + BlackCell.blackDies;
            foreach(var i in Map)
            {
                i.Check(Map, ref temp);
            }
            for (int i = 0; i < Map.GetLength(0); i++)
            {
                for (int j = 0; j < Map.GetLength(1); j++)
                {
                    if (temp[i, j] == 0)
                    {
                        Map[i, j] = new WhiteCell(Map[i,j]);                       
                    }
                    if (temp[i,j] == 2)
                    {
                        Map[i, j] = new RedCell(Map[i, j]);
                    }
                    if (temp[i, j] == 1)
                    {
                        Map[i, j] = new BlackCell(Map[i,j]) ;
                        temp[i, j] = 0;
                    }
                }
            }
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            UpdateMap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true) 
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstUpdate();
            button2.Hide();
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FirstUpdate();
            RedCell.redDies = 0;
            BlackCell.blackDies = 0;
            label1.Text = "Red Death: " + RedCell.redDies;
            label2.Text = "Black Death: " + BlackCell.blackDies;
            timer1.Enabled = false;
        }       
    }
}

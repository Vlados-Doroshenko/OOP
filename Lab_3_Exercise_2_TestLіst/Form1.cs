using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_Exercise_2_TestLіst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_NamebuttonAdd_Click(object sender, EventArgs e)
        {
            if(peopleLіst.Text.Length != 0){

                memberLіst.Items.Add(peopleLіst.Text);
            }
            else MessageBox.Show("Bиберіть елемент зі списку або введіть новий");
        }

        private void button2_NamebuttonDelete_Click(object sender, EventArgs e)
        {
           while(memberLіst.CheckedIndices.Count > 0)
            memberLіst.Items.RemoveAt(memberLіst.CheckedIndices[0]);
        }

        private void button3_NamebuttonSort_Click(object sender, EventArgs e)
        {
            memberLіst.Sorted = true;
        }
    }
}

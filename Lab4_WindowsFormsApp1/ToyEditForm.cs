using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class ToyEditForm : Form
    {
        Toy theToy;
        public ToyEditForm(Toy toy)
        {
            InitializeComponent();
            theToy = toy;
            if (theToy.Name != null)
            {
                textBox1.Text = theToy.Name;
                textBox2.Text = theToy.Manufacturer;
                comboBox1.SelectedItem = theToy.ToyClass;
            }


        }
        Regex NameReg = new Regex(@"^[a-zA-Z]+\s?$");

        
        private void ToyEditForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Toy.Classification.Constructor);
            comboBox1.Items.Add(Toy.Classification.Doll);
            comboBox1.Items.Add(Toy.Classification.SoftToy);
            comboBox1.Items.Add(Toy.Classification.VehicleModel);
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" | textBox2.Text != "")
            {
                theToy.Name = textBox1.Text;
                theToy.Manufacturer = textBox2.Text;
                theToy.ToyClass = (Toy.Classification)comboBox1.SelectedItem;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Не можна створити iграшку без назви або виробника");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            theToy = new Toy();
            DialogResult = DialogResult.No;
            Close();
        }
    }
}

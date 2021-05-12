using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PartyEditForm : Form
    {
        PartyToys thePartyToys;
        public static List<Toy> allToys = new List<Toy>();
        public PartyEditForm(PartyToys partyToys)
        {

            InitializeComponent();
            thePartyToys = partyToys;
            if (partyToys.TheToy != null)
            {
                listBox1.Items.Add(partyToys);
            }
            foreach (Toy i in allToys)
            {
                listBox1.Items.Add(i);
            }
        }

        private void PartyEditForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toy toy = new Toy();
            ToyEditForm toyEdit = new ToyEditForm(toy);
            toyEdit.ShowDialog();
            if (toyEdit.DialogResult == DialogResult.OK)
            {
                allToys.Add(toy);
                listBox1.Items.Add(toy);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thePartyToys.TheToy = (Toy)listBox1.SelectedItem;
            thePartyToys.Date = dateTimePicker1.Value;
            thePartyToys.Price = (int)numericUpDown1.Value;
            thePartyToys.Count = (int)numericUpDown2.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            thePartyToys = new PartyToys();
            DialogResult = DialogResult.No;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        public void RefreshData()
        {
            listBox1.Items.Clear();
            foreach(var i in allToys)
            {
                listBox1.Items.Add(i);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ToyEditForm toyEdit = new ToyEditForm(allToys[listBox1.SelectedIndex]);
            toyEdit.ShowDialog();
            RefreshData();
        }
    }
}

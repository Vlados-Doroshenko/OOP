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
    public partial class ToyShopForm : Form
    {
        ToyShop theShop;
        public ToyShopForm(ToyShop toyShop)
        {
            InitializeComponent();
            theShop = toyShop;
            if(theShop != null)
            {
                MagInfo.Text = theShop.ToShortString();
                foreach(PartyToys party in theShop.supplies)
                {
                    listBox1.Items.Add(party);
                }
            }
            RefreshData();
        }
        
        private void RefreshData()
        {
            MagInfo.Text = theShop.ToShortString();
            listBox1.Items.Clear();
            foreach(PartyToys party in theShop.supplies)
            {
                listBox1.Items.Add(party);
            }
            if (listBox1.Items.Count != 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void ToyShopForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartyToys party = new PartyToys();
            PartyEditForm partyEdit = new PartyEditForm(party);
            partyEdit.ShowDialog();
            if(partyEdit.DialogResult == DialogResult.OK)
            { 
            theShop.AddAPartyofToys(party);
          
            RefreshData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                theShop.SellToy(listBox1.SelectedIndex);
                if (theShop.supplies[listBox1.SelectedIndex].Count == 0)
                {
                    theShop.supplies.RemoveAt(listBox1.SelectedIndex);
                }
                RefreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            theShop.supplies.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartyEditForm partyEdit = new PartyEditForm(theShop.supplies[listBox1.SelectedIndex]);
            partyEdit.ShowDialog();
            RefreshData();
        }
    }
}

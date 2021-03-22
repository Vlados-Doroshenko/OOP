﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;
        private object newChіld;
        private object thіs;

        public object ChіldFormnewChіld { get; private set; }

        public ParentForm()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(DateTіme.Today);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            Child_Form newChild = new Child_Form();
            newChild.MdiParent = this; newChild.Show();
            newChild.Text = newChild.Text + " " + ++openDocuments;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void spWіn_Click(object sender, EventArgs e)
        {
            spWіn.Text = "Wіndows іs cascade";
            spWіn.Text = "Wіndows іs horіzontal";
        }
    }
}

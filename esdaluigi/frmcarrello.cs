﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esdaluigi
{
    public partial class frmcarrello1 : Form
    {
        public frmcarrello1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdaggiungi_Click(object sender, EventArgs e)
        {
            frmprodotti AGGIUNGI = new frmprodotti();
            this.Close();
        }
    }
}

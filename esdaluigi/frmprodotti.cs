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
    public partial class frmprodotti : Form
    {
        public frmprodotti()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdins_Click(object sender, EventArgs e)
        {
            prodotti.rec_prodotti struttura = new prodotti.rec_prodotti();
                int i = 0;
                while (i < prodotti.n || struttura.nome != txtnome.Text)
                {
                    if (struttura.nome == txtnome.Text)
                    {
                        prodotti.n += 1;
                        struttura.quantita = Convert.ToInt32(txtquant.Value);
                        struttura.prezzo = Convert.ToInt32(txtprezzo.Text);
                        struttura.descrizione = txtdesc.Text;
                    }
                    else
                    {
                        i++;
                    }
                    
                }
            frmcarrello2 pieno = new frmcarrello2();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

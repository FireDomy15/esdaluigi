using System;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmdins_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) // -1 E' IL VALORE VUOTO
            {
                MessageBox.Show("Aggiungi un prodotto dalla lista");
                return;
            }
            Prodotto prodotto = Easycart.listino[comboBox1.SelectedIndex];
           Acquisto acquisto = Easycart.currentUser().carrello.Find(a => a.nomeProdotto == prodotto.nome);
            if(acquisto == null)
            {
                Easycart.currentUser().carrello.Add(new Acquisto(Decimal.ToInt32(txtquant.Value), prodotto.nome));
            }
            else
            {
                acquisto.quantita += Decimal.ToInt32(txtquant.Value);
            }
            
            frmcarrello2 pieno = new frmcarrello2();
            pieno.Show();
            this.Close();
        }

        private void frmprodotti_Load(object sender, EventArgs e)
        {
            foreach(Prodotto prodotto in Easycart.listino)
            {
                comboBox1.Items.Add(prodotto.nome);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prodotto prodotto = Easycart.listino[comboBox1.SelectedIndex];
            txtdesc.Text = prodotto.descrizione;
            txtprezzo.Text = prodotto.prezzo.ToString();
        }
    }
}

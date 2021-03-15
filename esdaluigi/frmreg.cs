using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace esdaluigi
{
    public partial class frmreg : Form
    {
        public frmreg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdconferma_Click(object sender, EventArgs e)
        {
            if (txtconfermapass.Text != txtpassword.Text)
            {
                MessageBox.Show("Le password non corrispondono");
                return;
            }
            if (Easycart.utenti.Find(x => x.username == txtusername.Text) != null)
            {
                MessageBox.Show("SEI GIA' REGISTRATO!");
                return;
            }
            User utente = new User(txtusername.Text, txtpassword.Text, txtnome.Text, txtcognome.Text, new List<Acquisto>());
            Easycart.utenti.Add(utente);
            Easycart.save();

            Easycart.currentUserIndex = Easycart.utenti.Count-1;
            frmcarrello2 VUOTO = new frmcarrello2();
            VUOTO.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbenvenuto LOGIN = new frmbenvenuto();
            LOGIN.Show();
            this.Hide();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

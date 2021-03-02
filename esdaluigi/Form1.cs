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
    public partial class frmbenvenuto : Form
    {
        public frmbenvenuto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmreg FRMREG = new frmreg();
            FRMREG.Show();
            this.Hide();
        }

        private void cmdaccedi_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("Utenti.txt");
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

           User utente = users.Find(x => x.username == txtusername.Text);
            if (utente?.password == txtpass.Text) // "?" = if(variabile !=null)
            {
                frmcarrello2 FRMCART = new frmcarrello2();
                FRMCART.Show();
                this.Close();
            }
            else
                MessageBox.Show("CREDENZIALI ERRATE!");
        }
    }
}

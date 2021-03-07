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

            int userIndex = users.FindIndex(x => x.username == txtusername.Text);
            if (userIndex != -1 &&
               Easycart.utenti[userIndex].password == txtpass.Text)
            {
                frmcarrello2 FRMCART = new frmcarrello2();
                Easycart.currentUserIndex = userIndex;
                FRMCART.Show();
                this.Hide();
            }
            else
                MessageBox.Show("CREDENZIALI ERRATE!");
        }
    }
}

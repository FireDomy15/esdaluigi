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
            /* IMPLEMENTARE CONFERMA DI REGISTRAZIONE + CONTROLLI DI CAMPI E CAZZI VARI*/
            /*CREARE NUOVO CODICE CARRELLO*/

            string json = File.ReadAllText("Utenti.txt");
            List <User> users = JsonSerializer.Deserialize<List<User>>(json);

            if(users.Find(x => x.username == txtusername.Text) != null)
            {
                MessageBox.Show("SEI GIA' REGISTRATO!");
                return;
            }

            User utente = new User(txtusername.Text, txtpassword.Text, txtnome.Text, txtcognome.Text);
            users.Add(utente);
            string jsonString = JsonSerializer.Serialize(users);
            File.WriteAllText("Utenti.txt", jsonString);

            frmcarrello1 VUOTO = new frmcarrello1();
            VUOTO.Show();
            this.Hide();
        }
    }
}

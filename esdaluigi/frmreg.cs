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
            frmcarrello1 VUOTO = new frmcarrello1();
            VUOTO.Show();
            this.Hide();
        }
    }
}

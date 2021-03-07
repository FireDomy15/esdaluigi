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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void registrazioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcarrello2 FRMCAR2 = new frmcarrello2();
            FRMCAR2.Hide();
            this.Hide();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprodotti FRMPRO = new frmprodotti();
            FRMPRO.Hide();
            this.Hide();


        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbenvenuto FRMBEN = new frmbenvenuto();
            Easycart.currentUserIndex = Easycart.NO_USER;
            FRMBEN.Show();
            this.Hide();
        }

        private void chiudiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

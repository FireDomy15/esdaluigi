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
    public partial class frmcarrello2 : Form
    {
        public frmcarrello2()
        {
            InitializeComponent();
        }

        private void cmdaggiungi_Click(object sender, EventArgs e)
        {
            frmprodotti AGGIUNGI = new frmprodotti();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblprezzo_Click(object sender, EventArgs e)
        {

        }

        private void cmdelimina_Click(object sender, EventArgs e)
        {

        }
    }
}

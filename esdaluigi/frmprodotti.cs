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

        private void cmdins_Click(object sender, EventArgs e)
        {
            frmcarrello2 pieno = new frmcarrello2();
            this.Close();
        }
    }
}

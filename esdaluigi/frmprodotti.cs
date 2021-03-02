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
            prodotti.rec_prodotti struttura = new prodotti.rec_prodotti();
                int i = 0;
                while (i < prodotti.n || struttura.nome != cboprodotto.text)
                {
                    if (prodotti.nome == cboprodotto.text)
                    {
                        prodotti.n += 1;
                        struttura.quantita = Convert.ToInt32(txtquant.text);
                        struttura.prezzo = Convert.ToInt32(txtprezzo.Text);
                        struttura.codice = txtcod.Text;
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

    }
}

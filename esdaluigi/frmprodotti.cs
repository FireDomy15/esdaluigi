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
            *button aggiungi_prodottoClick
 {
                int i = 0;
                while (int i < dati.n || dati.prodotti.nome != cboprodotto.text)
    {
                    if (dati.prodotti.nome == cboprodotto.text)
                    {
                        dati.n += 1;
                        dati.prodotti.quantita = txtquant.text;
                        dati.prodotti.prezzo = txtprezzo.text;
                        dati.prodotti.sconto = txtsconto.text;
                        dati.prodotti.codice = txtcodice.text;
                        dati.prodotti.descrizione = txtdescr.text;
                    }
                    else
                    {
                        i++;
                    }

                }
            }

        }
    }
}

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
        private void frmcarrello2_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmprodotti aggiungi = new frmprodotti();
            aggiungi.Show();
            this.Hide();
        }

        private void frmcarrello2_Shown(Object sender, EventArgs e)
        {
            refresh_List(); //CHIAMATA AL METODO DI SOTTO
        }

        private void cmdelimina_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count==0)
            {
                MessageBox.Show("Seleziona un elemento");
                return;
            }
            Easycart.currentUser().carrello.RemoveAt(listView1.SelectedIndices[0]);
            refresh_List();
        }

        private void refresh_List()
        {
            listView1.Items.Clear();
            foreach (Acquisto acquisto in Easycart.currentUser().carrello)
            {
                Prodotto prodotto = Easycart.listino.Find(p => p.nome == acquisto.nomeProdotto);
                listView1.Items.Add(new ListViewItem(new string[]
                {
                    prodotto.nome,
                    prodotto.descrizione,
                    prodotto.prezzo.ToString(),
                    acquisto.quantita.ToString()
                }));
            }
        }

        private void frmcarrello2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Easycart.save();
        }

        private void frmcarrello2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

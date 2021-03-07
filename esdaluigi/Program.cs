using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace esdaluigi
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CARICAMENTO DEL LISTINO
            string json = File.ReadAllText(Easycart.PRODUCTS_PATH);
            Easycart.listino = JsonSerializer.Deserialize<List<Prodotto>>(json);

            //CONTROLLO ESISTENZA DEI FILE
            if(!File.Exists(Easycart.USERS_PATH))
            {
                using (StreamWriter sw = File.CreateText(Easycart.USERS_PATH))
                {
                    sw.WriteLine("[]"); //INIZIALIZZO UNA LISTA UTENTI VUOTA
                }
            }
            else
            {
                string usersJson = File.ReadAllText(Easycart.USERS_PATH);
                Easycart.utenti = JsonSerializer.Deserialize<List<User>>(usersJson);
            }

            Application.Run(new frmbenvenuto());
        }
    }
}

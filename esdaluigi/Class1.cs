using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esdaluigi
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }

        public User(string username, string password, string nome, string cognome)
        {
            this.username = username;
            this.password = password;
            this.nome = nome;
            this.cognome = cognome;
        }
        
    }

    class prodotto
    {
        public string nome;
        public double prezzo;
        public string descrizione;
    
        public prodotto(string nome, double prezzo, string descrizione)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.descrizione = descrizione;
        }
    }
    /*class prodotti
    {
        public static int n;

        public struct rec_prodotti
        {
            public string nome;
            public int quantita;
            public double prezzo;
            public double sconto;
            public string codice;
            public string descrizione;
        }
    }*/
}
}

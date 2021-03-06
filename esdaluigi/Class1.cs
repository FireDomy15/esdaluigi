﻿using System;
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
        public List<Acquisto> carrello { get; set; }

    public User(string username, string password, string nome, string cognome, List<Acquisto> carrello)
        {
            this.username = username;
            this.password = password;
            this.nome = nome;
            this.cognome = cognome;
            this.carrello = carrello;
        }
        
    }

    class Prodotto
    {
        public string nome { get; set; }
        public double prezzo { get; set; }
        public string descrizione { get; set; }

        public Prodotto(string nome, double prezzo, string descrizione)
        {
            this.nome = nome;
            this.prezzo = prezzo;
            this.descrizione = descrizione;
        }
    }

    class Acquisto
    {
        public int quantita { get; set; }
        public string nomeProdotto { get; set; }

        public Acquisto(int quantita, string nomeProdotto)
        {
            this.quantita = quantita;
            this.nomeProdotto = nomeProdotto;
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

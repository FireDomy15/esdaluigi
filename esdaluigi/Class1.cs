using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

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

    class Easycart
    {
        public static int currentUserIndex = NO_USER;
        public static List<Prodotto> listino = new List<Prodotto>();
        public static List<User> utenti = new List<User>();
        public const string USERS_PATH = "Utenti.txt"; // COSTANTE
        public const string PRODUCTS_PATH = "Prodotti.txt"; // COSTANTE
        public const int NO_USER = -1;
        public static User currentUser()
        {
            return utenti[currentUserIndex];
        }

        public static void save()
        {
            string jsonString = JsonSerializer.Serialize(utenti);
            File.WriteAllText(USERS_PATH, jsonString);
        }

        // NON SI INIZIALIZZA IL COSTRUTTORE PERCHE'
        // LA CLASSE E' STATICA
    }
}

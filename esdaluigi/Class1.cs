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
}

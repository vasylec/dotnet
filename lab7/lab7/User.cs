using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class User
    {
        public string login,  nume, prenume, bday, parola;

        public User(string login, string nume, string prenume, string bday, string parola)
        {
            this.login = login;
            this.nume = nume;
            this.prenume = prenume;
            this.bday = bday;
            this.parola = parola;
        }
    }
}

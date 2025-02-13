using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formular_Creare_Cont
{
    internal class user
    {
        string username, fname, lname, bday, password;
        static int index;
        public user(string username, string fname, string lname, string bday, string password)
        {
            this.username = username;
            this.fname = fname;
            this.lname = lname;
            this.bday = bday;
            this.password = password;
            index++;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public string Bday
        {
            get { return bday; }
            set { bday = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public static int getIndex()
        {
            return index;
        }
        public static void setIndex(int i)
        {
            index = i;
        }
    }
}

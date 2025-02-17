using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class elev
    {
        public string nume { get; set; }
        public string bday;
        public int an { get; set; }
        public int[] note = new int[4];
        
        public elev(string nume, string bday, int an, int[] note)
        {
            this.nume = nume;
            this.bday = bday;
            this.an = an;
            this.note = note;
        }
    }
}

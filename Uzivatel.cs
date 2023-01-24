using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecnyprojekt
{ //objekt uzivatel
    internal class Uzivatel
    {
        // atributy uživatele
        public string jmeno { get; set; }
        public string prijmeni { get; set; }

        public int telefonnicislo { get; set; }
        public int vek { get; set; }

        public Uzivatel(string jmeno, string prijmeni, int telefonnicislo, int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.telefonnicislo = telefonnicislo;
            this.vek = vek;
        }
        
       
        public override string ToString()
        {
            return jmeno + " "+ prijmeni + " " + Convert.ToString (telefonnicislo) + " "+ Convert.ToString(vek);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zaverecnyprojekt;

namespace Zaverecnyprojekt
{ // třída databaze
    internal class Databaze 
    {
        private List<Uzivatel> uzivatele;

        public Databaze()
        {
            uzivatele = new List<Uzivatel>();

        }
        // přidání uživatele 
        public void PridejUzivatele(string jmeno, string prijmeni, int telefonnicislo, int vek)
        {
            uzivatele.Add(new Uzivatel(jmeno,prijmeni,telefonnicislo,vek));

        }
        
        // vyhledání uživatele
        public List<Uzivatel> VyhledejUzivatele(string jmeno,string prijmeni)
        {
            List<Uzivatel>vysledek=new List<Uzivatel>();
            foreach (Uzivatel vyhledany in uzivatele)
            {
                if (vyhledany.jmeno == jmeno && vyhledany.prijmeni == prijmeni) vysledek.Add(vyhledany);
            }
            return vysledek;
        }
        public List<Uzivatel> VyhledejUzivatele(string jmenoPrijmeni)
        {
            List<Uzivatel> vysledek = new List<Uzivatel>();
            
            foreach (Uzivatel vyhledany in uzivatele)
            {
                if (vyhledany.jmeno == jmenoPrijmeni || vyhledany.prijmeni == jmenoPrijmeni) vysledek.Add(vyhledany);
            }
            return vysledek;
        }
        

        //vypsání všech uživatelů
        public List<Uzivatel> VypisVsechny()
        {
            return uzivatele;
        }

 
        
       
    }


}







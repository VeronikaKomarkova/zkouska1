using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecnyprojekt
{//zoufale vytvořená a špatně pojmenovaná třída pro uklizení metod :(
    internal class Seznam
    {

        //přidání uživatele
        public void PridejUzivatele(Databaze databaze)
        {
            string jmeno, prijmeni;
            int vek = 0, telefonnicislo = 0;


            Console.WriteLine("Zadejte jméno uživatele:");
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine())
               ) Console.WriteLine("Zadejte jméno znovu:");

            Console.WriteLine("Zadejte příjmení uživatele:");
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine())
               ) Console.WriteLine("Zadejte příjmení znovu:");

            
            while (telefonnicislo == 0)
            {
                Console.WriteLine("Zadejte telefonní číslo uživatele (bez předvolby):");
                try
                {
                    telefonnicislo=Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Zadali jste neplatné telefonní číslo");
                }

            }

            
            while (vek == 0)
            {
                Console.WriteLine("Zadejte věk uživatele:");
                try
                {
                    vek=Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Zadali jste neplatnou hodnotu");
                }

            }
            databaze.PridejUzivatele(jmeno, prijmeni, telefonnicislo, vek);
        }

        //vyhledání uživatele
        public void VyhledejUzivatele(Databaze databaze)
        {
            string hledany = Console.ReadLine().ToLower();
            foreach (Uzivatel vyhledany in databaze.VyhledejUzivatele(hledany))
             Console.WriteLine("Nalezení uživatelé:" + vyhledany.ToString());
            




        }
    }
}

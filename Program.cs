using System.ComponentModel.Design;
using System.Collections.Generic;
using System;
using Zaverecnyprojekt;

{
    // odkazuji na třídu databáze a třídu seznam
    Databaze databaze = new Databaze();
    Seznam seznam = new Seznam();


    char volba = '0';

    while (volba != '4')
    {
        // vypsání úvodu

        Console.WriteLine("---------------------");
        Console.WriteLine("Evidence pojištěných");
        Console.WriteLine("---------------------");
       
        
        Console.WriteLine("Vyberte si akci:");
        Console.WriteLine("1 - Přidat nového pojištěného");
        Console.WriteLine("2 - Vypsat všechny pojištěnce");
        Console.WriteLine("3 - Vyhledejte pojištěného");
        Console.WriteLine("4 - Konec");
        volba = Console.ReadKey().KeyChar;
        Console.WriteLine();
        // cyklus switch pro to jakou akci uživatel zvolí 
        switch (volba)
        {
            case '1':
                
                seznam.PridejUzivatele(databaze);
                break;
            case '2':
                Console.WriteLine("Výpis všech uživatelů:");
                foreach (Uzivatel uziv in databaze.VypisVsechny())
                {
                    Console.WriteLine(uziv.ToString());
                }

                break;
            case '3':
                Console.WriteLine("Pro vyhledání zadejte jméno nebo příjmení uživatele");
                seznam.VyhledejUzivatele(databaze);
                break;
            case '4':
                Console.WriteLine("Libovolnou klávesou ukončíte program.");
                break;
            default:
                Console.WriteLine("Neplatné zadání, stiskněte libovolnou klávesu a opakujte zadání.");
                break;

        }

    }






}

Console.ReadKey();
/*
 * Auteur: Rogier van der Linde
 * Datum: 2025-11-27
 * Onderwerp: programma herschrijven met methodes
 */

using System;
using System.Text;

namespace Visitekaartjes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string naam;
            do
            {
                // naam inlezen
                bool naamOk = false;
                do
                {
                    Console.Write("Geef een naam (of ENTER om te stoppen): ");
                    naam = Console.ReadLine();
                    naamOk = string.IsNullOrWhiteSpace(naam) || naam.Length >= 2;
                    if (!naamOk)
                    {
                        Console.WriteLine("Ongeldige naam. Probeer opnieuw.");
                    }
                } 
                while (!string.IsNullOrWhiteSpace(naam) && naam.Length < 2);

                if (string.IsNullOrWhiteSpace(naam)) break;

                // Geboortedatum inlezen
                DateTime geboortedatum = DateTime.Today, nu = DateTime.Today;
                bool geboortedatumOk = false;
                while (!geboortedatumOk)
                {
                    Console.Write("Geboortedatum (yyyy-mm-dd): ");
                    string input = Console.ReadLine();
                    geboortedatum = Convert.ToDateTime(input);
                    geboortedatumOk = geboortedatum <= nu && geboortedatum >= nu.AddYears(-120);
                    if (!geboortedatumOk)
                    {
                        Console.WriteLine("Ongeldige geboortedatum. Probeer opnieuw.");
                    }
                } 

                // Geslacht inlezen
                char geslacht = 'm';
                bool geslachtOk = false;
                while (!geslachtOk)
                {
                    Console.Write("Geslacht (m/v): ");
                    geslacht = Console.ReadKey().KeyChar;
                    geslachtOk = geslacht == 'm' || geslacht == 'v';
                    if (!geslachtOk)
                    {
                        Console.WriteLine("\nOngeldig geslacht. Tik 'm' of 'v'.");
                    }
                }

                // Leeftijdbepaling
                int leeftijd = DateTime.Today.Year - geboortedatum.Year;
                if (geboortedatum > DateTime.Today.AddYears(-leeftijd)) leeftijd--;

                // Leeftijdscategorie → emoji
                string emoji = "";

                if (geslacht == 'm')
                {
                    if (leeftijd < 3) emoji = "👶🏻";
                    else if (leeftijd < 12) emoji = "🧒🏻";
                    else if (leeftijd < 18) emoji = "👦🏻";
                    else if (leeftijd < 60) emoji = "👨🏻";
                    else emoji = "👨🏻‍🦳";
                }
                else
                {
                    if (leeftijd < 3) emoji = "👶🏼";
                    else if (leeftijd < 12) emoji = "🧒🏼";
                    else if (leeftijd < 18) emoji = "👧🏼";
                    else if (leeftijd < 60) emoji = "👩🏻";
                    else emoji = "👩🏻‍🦳";
                }

                // Stijl vragen
                Console.Write("\nStijl (1 of 2): ");
                int stijl = Convert.ToInt32(Console.ReadKey().KeyChar);

                // Visitekaartje genereren
                string kaartje = "";

                if (stijl == 1)
                {
                    kaartje = $@"┌─────────────── ────────────┐
│                            │
│      {naam} {emoji}      
│                            │
└────────────────────────────┘"; ;
                }
                else
                {
                    kaartje = $"✦ {naam} {emoji} ✦";
                }
                Console.WriteLine($"\n\n{kaartje}\n");
            } while (!string.IsNullOrEmpty(naam));

            Console.WriteLine("Programma beëindigd.");
        }
    }
}

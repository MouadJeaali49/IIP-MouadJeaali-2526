
/*
* Auteur: Mouad Jeaali
*Datum: 03/12/2025
*/
using System;
using System.Text;

namespace ConsoleComplexiteit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string woord;

            do
            {
                Console.Write("Geef een naam (of ENTER om te stoppen): ");
                woord = Console.ReadLine().ToLower();

                if (!string.IsNullOrWhiteSpace(woord))
                {
                    int aantalLetters = woord.Length;
                    int lettergrepen = AantalLettergrepen(woord);
                    double complex = Complexiteit(woord);

                    Console.WriteLine($"aantal karakters: {aantalLetters}");
                    Console.WriteLine($"aantal lettergrepen: {lettergrepen}");
                    Console.WriteLine($"complexiteit: {complex:0.0}");
                    Console.WriteLine();
                }

            } while (!string.IsNullOrWhiteSpace(woord));

            Console.WriteLine();
            Console.WriteLine("Bedankt en tot ziens.");
        }

        static bool IsKlinker(char c)
        {
            char[] klinkers = { 'a', 'e', 'i', 'o', 'u', 'y' };
            return Array.Exists(klinkers, k => k == c);
        }

        static int AantalLettergrepen(string woord)
        {
            int count = 0;
            bool vorigeWasKlinker = false;

            foreach (char c in woord)
            {
                if (IsKlinker(c))
                {
                    if (!vorigeWasKlinker)
                        count++;

                    vorigeWasKlinker = true;
                }
                else
                {
                    vorigeWasKlinker = false;
                }
            }

            return count;
        }

        static double Complexiteit(string woord)
        {
            double aantalLetters = woord.Length;
            double lettergrepen = AantalLettergrepen(woord);

            double totaal = (aantalLetters / 3) + lettergrepen;

            if (woord.Contains('q')) totaal += 1;
            if (woord.Contains('x')) totaal += 1;
            if (woord.Contains('y')) totaal += 1;

            return Math.Round(totaal, 1);
        }
    }
}
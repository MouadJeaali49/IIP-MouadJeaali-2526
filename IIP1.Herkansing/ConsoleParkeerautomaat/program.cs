
/*
 * Auteur: Mouad Jeaali
 * Datum: 2026-01-27
 */
using System;
using System.Text
using System.Globalization;

namespace ConsoleParkeerautomaat
class Program
{
    static void Main()
    {
        // constanten
        const double PRIJS_PER_UUR = 2.50;
        const double PRIJS_PER_DAG = 15.00;

        // variabelen
        string ticketType = "";
        int aantalUren = 0;
        double ticketPrijs = 0.0;
        double saldo = 0.0;

        bool klaar = false;

        while (!klaar)
        {
            Console.Clear();
            Console.WriteLine("--- 🚗 PARKEERAUTOMAAT 🚗 ---");
            Console.WriteLine("(a) Parkeerticket kiezen");
            Console.WriteLine("(b) Geld invoeren");
            Console.WriteLine("(c) Ticket afdrukken");
            Console.WriteLine("(q) Annuleren");
            Console.WriteLine();

            if (ticketType != "")
            {
                Console.WriteLine("Tickettype: " + ticketType);
                Console.WriteLine("Ticketprijs: €" + ticketPrijs);
            }

            Console.WriteLine("Saldo: €" + saldo);
            Console.WriteLine();
            Console.Write("Keuze: ");

            string keuze = Console.ReadLine().ToLower();

            switch (keuze)
            {
                case "a":
                    Console.WriteLine("Kies tickettype:");
                    Console.WriteLine("(1) Uurtarief");
                    Console.WriteLine("(2) Dagtarief");
                    string typeKeuze = Console.ReadLine().ToLower();

                    if (typeKeuze == "1")
                    {
                        ticketType = "Uurtarief";
                        Console.Write("Aantal uren (min.1u, max.12u): ");
                        int ingevoerd = int.Parse(Console.ReadLine());
                        aantalUren = Math.Min(12, Math.Max(1, ingevoerd));
                        ticketPrijs = aantalUren * PRIJS_PER_UUR;
                    }
                    else if (typeKeuze == "2")
                    {
                        ticketType = "Dagtarief";
                        ticketPrijs = PRIJS_PER_DAG;
                    }
                    break;

                case "b":
                    Console.WriteLine("Voer geld in (0 om te stoppen):");
                    while (true)
                    {
                        double bedrag = double.Parse(Console.ReadLine());
                        if (bedrag == 0)
                            break;

                        saldo += bedrag;
                    }
                    break;

                case "c":
                    if (saldo < ticketPrijs)
                    {
                        double tekort = ticketPrijs - saldo;
                        Console.WriteLine("Fout: nog €" + tekort + " nodig.");
                        Console.WriteLine("Druk op een toets om verder te gaan...");
                        Console.ReadKey();
                    }
                    else
                    {
						Console.WriteLine(" 📃 Ticket afrdrukken ...");
						Console.WriteLine();
                        Console.WriteLine("--- PARKEERTICKET ---");
                        Console.WriteLine("Type: " + ticketType);
						Console.WriteLine("Uren: " + aantalUren);
                        Console.WriteLine("Prijs: €" + ticketPrijs);
                        Console.WriteLine("Betaald: €" + saldo);
						Console.WriteLine();
                        Console.WriteLine("Bedankt en een fijne dag 🚗");
                        klaar = true;
                    }
                    break;

                case "q":
                    klaar = true;
                    break;
            }
        }
    }
}

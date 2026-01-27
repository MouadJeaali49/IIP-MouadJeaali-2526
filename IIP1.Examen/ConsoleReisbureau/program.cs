using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleReisbureau 
{
   class Program
   {
	   
	   //constanten
		const double PRIJS_VOLWASSENE = 299.99;
		const double PRIJS_KIND = 199.50;
		const double TOESLAG_PERCENTAGE = 0.03;
		const int MIN_LEEFTIJD_VOLWASSEN = 16;
		
		
      static void Main(string[] args)
      {
		
		Console.OutputEncoding = Encoding.UTF8;
		
		//variabele
		int aantalPersonen = 0;
        int aantalKinderen = 0;
        int aantalVolwassenen = 0;
        bool gegevensIngevuld = false;

        char keuze;

        do
        {
			Console.Clear();
            Console.WriteLine("Welkom bij Reisbureau Ibiza");
            Console.WriteLine();
            Console.WriteLine("(a) Reisgegevens invullen");
            Console.WriteLine("(b) Boeking bekijken");
            Console.WriteLine("(q) Betalen en afsluiten");
            Console.Write("Maak uw keuze: ");

            keuze = Console.ReadKey().KeyChar;
            Console.WriteLine();
			
			switch (keuze)
            {
                case 'a':
                case 'A':
                    Console.Write("Geef het aantal personen op: ");

                    if (int.TryParse(Console.ReadLine(), out aantalPersonen))
                    {
                        aantalKinderen = 0;
                        aantalVolwassenen = 0;

                        for (int i = 1; i <= aantalPersonen; i++)
                        {
                            Console.Write($"Leeftijd persoon {i}: ");
                            int leeftijd = int.Parse(Console.ReadLine());
							if (leeftijd < MIN_LEEFTIJD_VOLWASSEN)
                                aantalKinderen++;
                            else
                                aantalVolwassenen++;
                        }

                        gegevensIngevuld = true;

                        Console.WriteLine();
                        Console.WriteLine($"Er werden {aantalKinderen} kinderen en {aantalVolwassenen} volwassenen geregistreerd.");
                        Console.WriteLine("Druk op een toets om verder te gaan...");
                        Console.ReadKey();
						}
                    else
                    {
                        Console.WriteLine("Ongeldige invoer! Druk op een toets om verder te gaan...");
                        Console.ReadKey();
                    }
                    break;
					
				case 'b':
                case 'B':
                    if (!gegevensIngevuld)
                    {
                        Console.WriteLine("Je hebt nog geen reis geboekt.");
                    }
                    else
                    {
                        double totaalPrijs =
                            aantalKinderen * PRIJS_KIND +
                            aantalVolwassenen * PRIJS_VOLWASSENE;

                        Console.WriteLine("Boekingsoverzicht:");
                        Console.WriteLine($"Aantal kinderen: {aantalKinderen}");
                        Console.WriteLine($"Aantal volwassenen: {aantalVolwassenen}");
                        Console.WriteLine($"Totale prijs: {totaalPrijs.ToString("0.00", CultureInfo.InvariantCulture)}");
					}
					
					Console.WriteLine();
                    Console.WriteLine("Druk op een toets om verder te gaan...");
                    Console.ReadKey();
                    break;
					
				case 'q':
                case 'Q':
                    if (!gegevensIngevuld)
                    {
                        Console.WriteLine("Je hebt nog geen reis geboekt. Programma wordt afgesloten.");
                        break;
                    }

                    double basisPrijs =
                        aantalKinderen * PRIJS_KIND +
                        aantalVolwassenen * PRIJS_VOLWASSENE;

                    Console.Write("Wenst u met cash of kredietkaart te betalen? (cash/krediet): ");
                    string betaalkeuze = Console.ReadLine().ToLower();
					
					double totaalTeBetalen = basisPrijs;

                    if (betaalkeuze == "krediet")
                    {
                        double toeslag = basisPrijs * TOESLAG_PERCENTAGE;
                        totaalTeBetalen += toeslag;

                        Console.WriteLine($"Een toeslag van 3% wordt toegepast: {toeslag.ToString("0.00", CultureInfo.InvariantCulture)}");
                    }

                    Console.WriteLine($"Totale prijs: {totaalTeBetalen.ToString("0.00", CultureInfo.InvariantCulture)}");
                    Console.WriteLine("Bedankt voor het gebruik van Reisbureau Ibiza!");
                    break;
					
					default:
                    Console.WriteLine("Ongeldige keuze! Druk op een toets om verder te gaan...");
                    Console.ReadKey();
                    break;
            }

        } while (keuze != 'q' && keuze != 'Q');
    }
}
}

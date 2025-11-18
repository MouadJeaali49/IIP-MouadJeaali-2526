/*
 * Auteur: Mouad Jeaali
 * Datum: 2025-11-17
 */
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
      static void Main(string[] args)
      {
		
		Console.OutputEncoding = Encoding.UTF8;
		
		const int PrijsKind = 699;
		const int PrijsVolwassen = 899;
		const int Toeslag = 3%;
		const int Leeftijd = 16;
		
		int AantalKind = 0;
		int AantalVolwassenen = 0;
		int TotalePrijs = 0;
		
		
		
		Console.WriteLine(@"Welkom bij de Reisbureau Ibiza 🌎
		
(a) Reisgegevens invullen
(b) Boeking bekijken
(q) Betalen en afsluiten

Maak uw keuze: ");

		keuze = Console.ReadKey().KeyChar;
		switch(keuze){
			case('a'):
			Console.Writeline();
			Console.Write("\nAantal personen: ");
				personen = Convert.ToInt32(Console.ReadLine());
		if(Leeftijd < 0 && volwassenen == 0){
					Console.Write("\nje winkelmandje is leeg.");
				}

		Console.WriteLine($"Er werden {AantalKind} kinderen en {Aantal");
		Console.Read();
      }
   }
}




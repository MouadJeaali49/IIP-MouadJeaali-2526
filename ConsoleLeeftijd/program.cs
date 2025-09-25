/*
* Auteur: Mouad Jeaali
*Datum: 25/09/2025
*/
using System;

namespace ConsoleGangsterName
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Wat is je voornaam? ");
			string voornaam = Console.ReadLine();
			
			Console.Write("Hoe oud ben je? ");
			int leeftijd = int.Parse(Console.ReadLine());
			
			Console.Write("Geef is je lievelingsletter: ");
			char keuze = Console.ReadKey().KeyChar;
			
			// Lege regel toevoegen
			Console.WriteLine();
			
			Console.WriteLine();
			
			// Tweede alinea
			Console.WriteLine($"Hallo {voornaam}! Jij bent {leeftijd} jaar.");
			Console.WriteLine($"Volgend jaar ben je {leeftijd + 1}.");
			Console.WriteLine($"Jouw lievelingsletter is: {keuze}");
			
			// Wacht op toets zodat de console niet direct sluit
			Console.ReadKey(true);
		}
	}	
}	
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
			string header = "***********************\n"+
			"| GANSTA NAME BUILDER |\n" +
			"***********************";
			Console.WriteLine(header);

			Console.WriteLine("");
			Console.WriteLine("");
			
			// vraag de voornaam van een Disney karakter
			Console.Write("Give the first name of a Disney character: ");
			string disneyName = Console.ReadLine();
			
			// Vraag een workbench tool
			Console.Write("Give any workbench tool: ");
			string tool = Console.ReadLine();
			
			// vraag de achternaam
			Console.Write("What is your last name: ");
			string lastName = Console.ReadLine();
			
			// Bouw de GangstaName
			string gangstaName = disneyName + " 'the " + tool + "' " + lastName;
			
			// Lege regel toevoegen
			Console.WriteLine("");
			
			// kleur in het groen zetten
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ("Your gangsta name: " + gangstaName);
			Console.ResetColor();
			
			// Wacht op toets zodat de console niet direct sluit
			Console.ReadKey(true);
		}
	}
}

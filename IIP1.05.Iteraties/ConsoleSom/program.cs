/*
* Auteur: Mouad Jeaali
*Datum: xx/xx/2025
*/
using System;
using System.Text;
using System.Globalization;

namespace ConsoleSom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			int som = 0;
			string invoer;
			
			do
			{ 
				Console.Write("Voer een getal in (q om te stoppen): ");
				invoer = Console.ReadLine();
				
				if (invoer.ToLower() != "q")
				{ 
					int getal = int.Parse(invoer);
					som += getal;
				}
				
			} while (invoer.ToLower() != "q");
			
			Console.WriteLine($"De som is: {som}");
			
			Console.ReadKey();
		}
	}
}
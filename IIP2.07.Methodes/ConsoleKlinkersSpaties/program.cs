
/*
* Auteur: Mouad Jeaali
*Datum: 03/12/2025
*/
using System;
using System.Text;
using System.Globalization;

// namespace ConsoleKlinkersSpaties
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.Write("Geef een tekst: ");
            string input = Console.ReadLine();
			
			int aantalKlinkers = 0;
			int aantalSpaties = 0;
			
			string geheimschrift = "";
			
			foreach (char c in input)
			{
				// tellen van de klinkers
				if ("aeiouAEIOU".Contains(c))
				{
					aantalKlinkers++;
				}
				
				// tellen van de spaties
				if(c == ' ')
				{
					aantalSpaties++;
				}
				
				//geheimschrift maken
				if(char.IsLetter(c))
				{
					char volgendeLetter;
					
					if (c == 'z') volgendeLetter = 'a';
					else if (c == 'Z') volgendeLetter = 'A';
					else volgendeLetter =(char)(c + 1);
					
					geheimschrift += volgendeLetter;
				}
				else
				{
					geheimschrift += c;
				}
			}
			
			Console.WriteLine($"deze tekst bevat {aantalKlinkers} klinkers en {aantalSpaties} spaties");
			Console.WriteLine($"in geheimschrift: {geheimschrift}");
			
			Console.ReadKey();
		}
	}

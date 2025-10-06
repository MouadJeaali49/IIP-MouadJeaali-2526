using System;
using System.Text;

namespace ConsoleAbonnement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.WriteLine("Bestelgegevens");
			string header = "================\n";
			Console.WriteLine(header);
			Console.Write("Geef je naam: ");
			string Naam = Console.ReadLine();
			
			Console.Write("aantal toegangsbeurten: ");
			int toegangsbeurten = int.Parse(Console.ReadLine());
			
			Console.Write("prijs (b.v. 122,5): ");
			string prijs = Console.ReadLine();
			
			Console.Write("badkledij inbegrepen (typ true of false): ");
            bool inbegrepen = Convert.ToBoolean (Console.ReadLine());
			
			Console.Write("geslacht (druk 'm' of 'v'):");
			char geslacht = Console.ReadKey().KeyChar;
			Console.WriteLine();
			
			// Samenvatting tonen
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("Samenvatting");
			Console.WriteLine("================");
			
			Console.WriteLine($"- houder: {Naam}");
			Console.WriteLine($"- geslacht: {geslacht}");
			Console.WriteLine($"- prijs: {prijs}");
			Console.WriteLine($"- aantal beurten: {toegangsbeurten}");
			Console.WriteLine($"- incl. badkledij: {inbegrepen}");
			
			//kaartnummer
			Random rnd = new Random();
			string kaartnummer = $"{rnd.Next(100, 1000)}-{rnd.Next(1000, 10000)}-{rnd.Next(10, 100)}"; 
			Console.WriteLine($"- kaartnummer: {kaartnummer}");
			Console.ResetColor();

			
			Console.WriteLine("");
			Console.WriteLine("druk op een toets om verder te gaan...");
			Console.ReadKey(true);
		}
	}
}
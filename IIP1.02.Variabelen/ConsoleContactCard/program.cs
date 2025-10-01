using System;
using System.Text;

namespace ConsoleContactCard
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.Write("Geef je naam: ");
			string Naam = Console.ReadLine();
			
			Console.Write("ben je gehuwd? (ja/nee): ");
			string gehuwdInput = Console.ReadLine();
			bool Gehuwd = gehuwdInput.ToLower() == "ja";
			
			Console.Write("Geef je telefoonnummer: ");
			string Telefoon = Console.ReadLine();
			
			Console.Write("Geef je leeftijd: ");
            int Leeftijd = int.Parse(Console.ReadLine());
			
			Console.Write("Geef je salaris (in €): ");
			double Salaris = double.Parse(Console.ReadLine());
			
			Console.Write("Geef je geslacht (m/v): ");
            char Geslacht = Console.ReadLine()[0];
			
			Console.Write("Geef je lengte (in meter): ");
            double Lengte = double.Parse(Console.ReadLine());
			
			// Lege regel toevoegen voor betere 
			Console.WriteLine("");
			
string output = 
"----------------\n" + 
"*\n" +
"* Naam: " + Naam + "\n" +
"* Gehuwd: " + (Gehuwd ? "ja" : "nee") + "\n" +
"* Telefoon: " + Telefoon + "\n" +
"* Leeftijd: " + Leeftijd + " jaar\n" +
"* Salaris: €" + Salaris.ToString("F2") + " per maand\n" +
"* Geslacht: " + Geslacht + "\n" +
"* Lengte: " + Lengte.ToString("F1") + "m\n" +
"* \n" +
"----------------";

			Console.WriteLine(output);
			Console.WriteLine("druk een toets om verder te gaan...");
			Console.ReadKey(true);
		}
	}
}
	
			
			
			
			
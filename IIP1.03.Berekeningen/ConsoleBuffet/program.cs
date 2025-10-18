using System;
using System.Text;

namespace ConsoleBuffet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			string header =@"
WELKOM IN HET BUFFETRESTAURANT
==============================

Alles is à volonté en dranken zijn inbegrepen!
!!Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!
";
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(header);
			Console.ResetColor();
			
			const decimal Seizoensbuffets = 18.5m;
			const decimal Dessertenbuffets = 7.95m;
			const decimal Kids = 8.95m;
			
			
			
			Console.Write($"Aantal seizoensbuffets (€{Seizoensbuffets}): ");
			int aantalSeizoensbuffets = int.Parse(Console.ReadLine() ??"0");
			
			Console.Write($"Aantal kids menus (€{Dessertenbuffets}): ");
			int aantalDessertenbuffets = int.Parse(Console.ReadLine() ?? "0");
			
			Console.Write($"Aantal kids menus (€{Kids}): ");
			int aantalKids = int.Parse(Console.ReadLine() ?? "0");
			
			Console.WriteLine("");
			Console.Write("Fooi  (0 indien geen): ");
			double Fooi = double.Parse(Console.ReadLine() ?? "0");
			
			//Berekening totaal 
			double totaal = (aantalSeizoensbuffets*Seizoensbuffets) +
							(aantalDessertenbuffets*Dessertenbuffets) +
							(aantalKids*Kids) + Fooi;
							
			//afronden naar beneden
			double afgerond = Math.Floor(totaal);
			
			Console.WriteLine($"Totaal te betalen: €{totaal:F2}");
			Console.WriteLine($"Afgerond naar beneden: €{afgerond}");
			
			//Caash betaling
			Console.Write("\nCash betaald: ");
			double cashBetaald = double.Parse(Console.ReadLine() ?? "0");
			
			double terug = cashBetaald - afgerond;

			//Wisselgeld berekenen
			int[] waarden = { 50, 20, 10, 5, 2, 1 };
			int [] aantal = new int [waarden.Length];
			
			double resterend = terug;
			for (int i = 0; i < waarden.Length; i++)
			{
				aantal[i] =(int)(resterend / waarden[i]);
				resterend %= waarden [i];
			}
			
			//resultaten tonen
			Console.WriteLine("U krijgt terug:");
			for (int i = 0; i < waarden.Length; i++)
			{
				string type = waarden[i] >=5 ? "briefje(s)" : "stuk(ken)";
				Console.WriteLine($"- {aantal[i]} {type} van {waarden[i]}");
			}

			Console.ReadKey();
		}
	}
}	
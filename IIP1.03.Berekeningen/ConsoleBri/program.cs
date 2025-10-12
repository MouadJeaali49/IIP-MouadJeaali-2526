using System;
using System.Text;

namespace ConsoleBri
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.WriteLine("BRI CALCULATOR 🏋️");
			string header = "=================";
			Console.WriteLine (header);
			
			Console.WriteLine("");

			Console.Write("Taille (in cm): ");
			double Taille = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Lengte (in cm): ");
			double Lengte = Convert.ToDouble(Console.ReadLine());
			
			// Omzetten naar meter
			double TailleMeter = Taille / 100;
			double LengteMeter = Lengte / 100;
			
			// BRI formule
			double BRI = 364.2 - 365.5 * Math.Sqrt(1 - Math.Pow(TailleMeter / (Math.PI * LengteMeter), 2));
			
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Je BRI bedraagt: {BRI:F1}");
			Console.ResetColor();

			
			Console.Write("\nEen BRI tussen ");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("3,41 en 4,44 ");
			Console.ResetColor();
			Console.Write("is normaal.");
			
			
			Console.ReadKey();
			
		}
	}
}
using System;
using System.Text;

namespace ConsoleBmiKleuren
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.WriteLine("BMI CALCULATOR");
			Console.WriteLine("==============");
			
			Console.Write("Lengte (in cm): ");
			int lengte = Convert.ToInt32(Console.ReadLine());
						
			Console.Write("Gewicht (in kg): ");
			int gewicht = Convert.ToInt32(Console.ReadLine());
			
			double lengteInMeter = lengte / 100.0;
			double BMI = gewicht / Math.Pow(lengteInMeter,2);
			
			Console.WriteLine($"Je BMI bedraagt: {BMI:F1}");
			Console.WriteLine();
			
			if (BMI < 18.5)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Je hebt ondergewicht");
			}
			else if (BMI >= 18.5 && BMI < 25)
			{
				Console.ForegroundColor  = ConsoleColor.Green;
				Console.WriteLine("Je gewicht is normaal");
			}
			else if (BMI >= 25 && BMI < 30)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Je hebt overgewicht");
			}
			else if (BMI >= 30)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Je hebt obesitas");
			}
			Console.ResetColor();
			Console.ReadKey();
		}
	}
}
			
			
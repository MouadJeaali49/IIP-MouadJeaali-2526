using System;
using System.Text;

namespace ConsoleBmi
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
			
			
			Console.ReadKey();
		}
	}
}
			
			
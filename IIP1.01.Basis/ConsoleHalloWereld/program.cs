using System;

namespace ConsoleHalloWereld
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hallo Wereld!");
			Console.Write("Hoe heet je?: ");
			string naam = Console.ReadLine();
			
			//Kleur op geel zetten
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Aangename kennismaking, {naam}");
			
			//Kleur terugzetten op standaard
			Console.ResetColor();
			
			Console.WriteLine("druk een toets om verder te gaan...");
			Console.ReadKey();
		}
	}
}

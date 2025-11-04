/*
* Auteur: Mouad Jeaali
*Datum: xx/xx/2025
*/
using System;
using System.Text;
using System.Globalization;

namespace ConsoleGgd
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.WriteLine("BEREKEN GROOTST GEMENE DELER");
			string header = "============================";
			Console.WriteLine (header);
			
			// twee getallen vragen
			Console.Write("Getal 1: ");
			int a = int.Parse(Console.ReadLine());
			
			Console.Write("Getal 2: ");
			int b = int.Parse(Console.ReadLine());
			
			// while-manier 
			while (a !=b)
			{ 
				if (a > b)
					a = a - b;
				else
					b = b - a;
			}
			
			//resultaat tonen
			Console.WriteLine($"De grootst gemene deler is: {a}");
			
			Console.ReadKey();
		}
	}
}
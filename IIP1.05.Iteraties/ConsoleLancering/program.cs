/*
* Auteur: Mouad Jeaali
*Datum: xx/xx/2025
*/
using System;
using System.Text;
using System.Globalization;

namespace ConsoleLancering
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			Console.Write("Hoeveel seconden tot lancering? ");
			int getal = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine();
			
			// for-versie
			Console.WriteLine("for-versie: ");
			for (int a = getal; a >= 1; a--)
			{
				Console.WriteLine($"{a}...");
			}
			Console.WriteLine("Lift off! ");
			Console.WriteLine();
			
			// do-while versie
			Console.WriteLine("do-while versie: ");
			int b = getal;
			do 
			{ 
			Console.WriteLine($"{b}...");
			b--;
			} while (b>=1);
			Console.WriteLine("Lift off! ");
			Console.WriteLine();
			
			// while-versie
			Console.WriteLine("while-versie: ");
			int c = getal;
			while (c >= 1)
			{
				Console.WriteLine($"{c}...");
				c--;
			}
			Console.WriteLine("Lift off! ");
			
			Console.ReadKey();
		}
	}
}

/*
* Auteur: Mouad Jeaali
*Datum: xx/xx/2025
*/
using System;
using System.Text;
using System.Globalization;

namespace ConsoleTafels
{
	internal class Program
	{
		private static int VraagPositiefGetal() 
		{
			int getal;
				Console.Write("Geef een positief getal: ");
				getal = Convert.ToInt32(Console.ReadLine());
				
				while (getal < 0)
				{
					Console.Write("Het getal moet positief zijn! Geef een getal: ");
					getal = Convert.ToInt32(Console.ReadLine());
				}
			return getal;
		}
		
		private static void MaakTafel (int get, int len = 10)
		{
			for (int i = 1; i <= len; i++)
			{
				Console.WriteLine($"{get} x {i} = {get * i}");
			}
		}
		
		private static void Main (string[] args)
		{
			Console.WriteLine("4x6 tafel:");
			MaakTafel(4, 6);
			Console.WriteLine();
			Console.ReadKey();
			
			Console.WriteLine("2x5 tafel:");
            MaakTafel(2, 5);
            Console.WriteLine();
            Console.ReadKey();
			
			Console.WriteLine("7X10 tafel:");
            MaakTafel(7);
            Console.WriteLine();
            Console.ReadKey();
            
            int get = VraagPositiefGetal();
			int len = VraagPositiefGetal();
			
            Console.WriteLine($"{get}x{len} tafel");
            MaakTafel(get, len);
            Console.ReadKey();
		}
	}
}
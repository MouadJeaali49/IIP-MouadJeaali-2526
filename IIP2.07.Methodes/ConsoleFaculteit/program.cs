
/*
* Auteur: Mouad Jeaali
*Datum: xx/xx/2025
*/
using System;
using System.Text;

namespace ConsoleFaculiteit
{
	internal class Program
	{
		private static int Faculteit(int n)
		{
			int fac = 1;
			
			for (int i = 1; i<= n; i++)
			{
				fac *= i;
			}
			
			return fac;
		}
		
		static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
			
			Console.WriteLine("FACULTEIT BEREKENEN");
			Console.WriteLine();
			
			Console.Write("Geef een geheel getal: ");
			int n = int.Parse(Console.ReadLine());
			
			int resultaat = Faculteit(n);
			
			Console.WriteLine($"De faculteit is {resultaat}");
		}
	}
}
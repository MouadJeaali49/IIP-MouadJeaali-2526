/*
* Auteur: Mouad Jeaali
*Datum: xx/xx/2025
*/
using System;
using System.Text;
using System.Globalization;

namespace ConsoleBankautomaat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			
			//constante voor het maximum bedrag dat je per keer mag afhalen
			const decimal MAX_AFHALING = 200m;
			
			//variabele voor het huidige saldo, start op €1000
			decimal saldo = 1000m;
			CultureInfo nl = new CultureInfo("nl-NL");
			
			bool stoppen = false;
			
			string header = """
			Bankautomaat
			============
			""";
			
			//keuze menu
			Console.WriteLine(header);
			Console.WriteLine("huidige saldo: " + saldo.ToString("C", nl));
			Console.WriteLine();
			Console.WriteLine("a. afhaling");
			Console.WriteLine("b. storting");
			Console.WriteLine("c. stoppen");
			Console.WriteLine();
			
			while (!stoppen)  
			{
				//welke letterkeuze
				Console.Write("je keuze: ");
				char keuze = Console.ReadKey().KeyChar; //leest 1 karakter
				Console.WriteLine();
			
				//welke optie is er gekozen?
				switch (keuze)
				{
					//keuze a
					case 'a': 
					Console.Write("welk bedrag wil je afhalen: ");
					decimal bedrag = Convert.ToDecimal(Console.ReadLine());
				
					//controle 1: is het bedrag positief 
					if (bedrag <= 0)
					{
						Console.WriteLine("fout: bedrag moet positief zijn");
					}
					//controle 2: bedrag mag niet hoger zijn als 200 of hoger zijn als de saldo
					else if (bedrag > MAX_AFHALING || bedrag > saldo)
					{
						//maximaal toegelaten afhaling bepalen
						decimal maximaal = saldo;
						if (MAX_AFHALING < saldo)
							maximaal = MAX_AFHALING;
						
						Console.WriteLine("fout: je kan maximaal " + maximaal + " afhalen");
					}
					// controle 3: enkel briefjes van 20 en 50 zijn mogelijk
					else if (bedrag % 10 != 0 || bedrag == 10 || bedrag == 30)
					{
						Console.WriteLine("fout: enkel briefjes van 20 en 50 zijn mogelijk");
					}
					else
					{
						//afhalen uitvoeren
						saldo -= bedrag;
						Console.WriteLine("afhaling ok - het nieuw saldo is " + saldo.ToString("C", nl));
					}
					break;
				
					case 'b' :
					Console.Write("welk bedrag wil je storten: ");
					decimal storting = Convert.ToDecimal(Console.ReadLine());
					saldo += storting;
					Console.WriteLine("storting ok - het nieuw saldo is " + saldo.ToString("C", nl));
					break;
				
					case 'c' :
					Console.WriteLine();
					Console.WriteLine("bedankt en tot ziens");
					stoppen = true;
					break;
				
					default:
					Console.WriteLine("ongeldige keuze");
					break;
					
				}
			
				Console.WriteLine();
				if (!stoppen)
				{
					Console.ReadKey();
				}
			
			} 
		}
	}
}
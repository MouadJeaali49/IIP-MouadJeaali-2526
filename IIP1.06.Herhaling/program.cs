/*
 * Auteur: Mouad Jeaali
 * Datum: 2026-01-09
 */
using System;
using System.Text;
using System.Globalization;

namespace ConsoleHerhalingCircus
{
   class Program
   {
      static void Main(string[] args)
      {
		
		Console.OutputEncoding = Encoding.UTF8;
		
		bool isAfgerond = false;
		char keuze=' ';
		int volwassenen = 0;
		int kinderen = 0;
		decimal totaalPrijs = 0;
		string stringTotaalPrijs = "";
		char jarig = 'n';
		int bonus=0;
		do{
			Console.WriteLine(@"Welkom bij de ticketshop voor ""Circus Stromboli""
			
(a) Tickets toevoegen
(b) Winkelmandje tonen
(c) Winkelmandje wissen
(q) Bestelling afronden");
			
			Console.Write("\nJe Keuze: ");
			keuze = Console.ReadKey().KeyChar;
			switch(keuze){
				case('a'):
				Console.Write("\nVolwassenen: ");
				volwassenen = Convert.ToInt32(Console.ReadLine());
				Console.Write("Kinderen: ");
				kinderen = Convert.ToInt32(Console.ReadLine());
				if(kinderen == 0 && volwassenen == 0){
					Console.Write("\nJe winkelmandje is leeg.");
				}
				else{
					Console.Write($"Er zijn tickets voor {volwassenen} volwassenen en {kinderen} kinderen toegevoegd aan je winkelmandje.");
				
				}
				Console.WriteLine();
				Console.Write("\n... druk op een toets om verder te gaan.");
				Console.ReadKey();
				Console.Clear();
				break;
				
				case('b'):
				
				if(volwassenen!=0)
				{
					Console.WriteLine();
					Console.Write("\nVolwassenen: ");
					for(int i = 0; i<volwassenen; i++){
					Console.Write("💼");
					}
				}
				else{
					Console.Write("\nje winkelmandje is leeg.");
				}
				if(kinderen!=0)
				{
					
					Console.Write("\nKinderen: ");
					for(int i = 0; i<kinderen; i++){
					Console.Write("💼");
					}
					Console.WriteLine();
				}
				else{
					Console.Write("\nJe winkelmandje is leeg.");
					Console.WriteLine();
				}
				Console.Write("\n... druk op een toets om verder te gaan.");
				Console.ReadKey();
				Console.Clear();
				break;
				
				case('c'):
				volwassenen = 0;
				kinderen = 0;
				Console.WriteLine();
				Console.Write("\nje winkelmandje is gewist");
				Console.WriteLine();
				Console.Write("\n... druk op een toets om verder te gaan.");
				Console.ReadKey();
				Console.Clear();
				break;
				
				case('q'):
				totaalPrijs = (volwassenen * 19.90m) + (kinderen * 12.50m);
				stringTotaalPrijs = totaalPrijs.ToString("C", new CultureInfo("nl-NL"));
				Console.WriteLine($"\nTotaalprijs: {stringTotaalPrijs}");
				Console.Write($"\nBen je jarig vandaag?(j/n): ");
				jarig = Console.ReadKey().KeyChar;
				if(jarig == 'j')
				{
					Console.WriteLine("\nGefeliciteerd je krijgt 7% korting op je totaalprijs.");
					totaalPrijs = totaalPrijs*0.93m;
					stringTotaalPrijs = totaalPrijs.ToString("C", new CultureInfo("nl-NL"));
					Console.WriteLine();
					Console.WriteLine($"\nTe betalen bedrag: {stringTotaalPrijs}");
					bonus = (int)(totaalPrijs/10m);
					Console.WriteLine();
					Console.WriteLine($"je hebt {bonus} bonuspunten verzameld.");
				}
				else
				{
					bonus = (int)(totaalPrijs/10m);
					Console.WriteLine($"\nje hebt {bonus} bonuspunten verzameld.");
				}
				Console.WriteLine("Tot ziens!");
				Console.Write("\ndruk op een toets om verder te gaan.");
				
				isAfgerond=true;
				
				Console.ReadKey();
				Console.Clear();
				break;
				
				default:
				Console.WriteLine();
				Console.WriteLine("\nOnbekende keuze.");
				Console.Write("\n... druk op een toets om verder te gaan.");
				Console.ReadKey();
				Console.Clear();
				break;
			}
			
		}while(isAfgerond!=true);

		Console.Read();
      }
   }
}
/*
 * Auteur: Mouad Jeaali
 * Datum: 2025-11-12
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			
			Console.Write("\nje Keuze: ");
			keuze = Console.ReadKey().KeyChar;
			switch(keuze){
				case('a'):
				Console.Write("\nVolwassenen: ");
				volwassenen = Convert.ToInt32(Console.ReadLine());
				Console.Write("Kinderen: ");
				kinderen = Convert.ToInt32(Console.ReadLine());
				if(kinderen == 0 && volwassenen == 0){
					Console.Write("\nje winkelmandje is leeg.");
				}
				else{
					Console.Write($"er zijn tickets voor {volwassenen} volwassenen en {kinderen} kinderen toegevoegd aan");
					Console.Write("\nje winkelmandje.");
				
				}
				Console.Write("druk op een toets om verder te gaan.");
				Console.ReadKey();
				Console.Clear();
				break;
				
				case('b'):
				
				if(volwassenen!=0)
				{
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
				}
				else{
					Console.Write("\nje winkelmandje is leeg.");
				}
				Console.Write("\ndruk op een toets om verder te gaan.");
				Console.ReadKey();
				Console.Clear();
				break;
				
				case('c'):
				volwassenen = 0;
				kinderen = 0;
				Console.Write("\nje winkelmandje is gewist");
				Console.Write("\ndruk op een toets om verder te gaan.");
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
					Console.WriteLine("\ngefeliciteerd je krijgt 9% korting");
					totaalPrijs = totaalPrijs*0.09m;
					stringTotaalPrijs = totaalPrijs.ToString("C", new CultureInfo("nl-NL"));
					Console.WriteLine($"\nde Totaal prijs is: {stringTotaalPrijs}");
					bonus = (int)(totaalPrijs%10m);
					Console.WriteLine($"je hebt {bonus} bonuspunten");
				}
				else
				{
					Console.WriteLine($"\nje hebt {bonus} bonuspunten");
				}
				Console.WriteLine("tot ziens");
				Console.Write("\ndruk op een toets om verder te gaan.");
				
				isAfgerond=true;
				
				Console.ReadKey();
				Console.Clear();
				break;
			}
			
		}while(isAfgerond!=true);

		Console.Read();
      }
   }
}
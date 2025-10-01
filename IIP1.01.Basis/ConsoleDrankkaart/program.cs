/*
* Auteur: Mouad Jeaali
*Datum: 25/09/2025
*/
using System;
using System.Text;
namespace ConsoleDrankkaart
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			string header = "@====== MENU ======\n"+
			"☕ Koffie:      3€\n" +
			"🍵 Thee:        2€\n" +
			"🥤 Limo:        2€";
			Console.WriteLine(header);
			Console.WriteLine("------------------");
			Console.WriteLine("copyright ©2025");
			
			// Lege regel toevoegen
			Console.WriteLine();
			
			Console.WriteLine("Het menu staat ook op \"C:\\Dropbox\\MijnCafe\\menu.pdf\"");
			
			// Wacht op toets zodat de console niet direct sluit
			Console.ReadKey(true);
		}
	}
}	
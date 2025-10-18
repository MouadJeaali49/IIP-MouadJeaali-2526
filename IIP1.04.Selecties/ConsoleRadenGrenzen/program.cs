using System;
using System.Text;

namespace ConsoleRadenGrenzen
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			

			string header = """
                   .___             
____________     __| _/____   ____  
\_  __ \__  \   / __ |/ __ \ /    \ 
 |  | \// __ \_/ /_/ \  ___/|   |  \
 |__|  (____  /\____ |\___  >___|  /
            \/      \/    \/     \/ 
""";
			Console.WriteLine(header);

			Console.WriteLine("Geef twee gehele getallen.");
			Console.Write("- getal 1: ");
			int getal1 = int.Parse(Console.ReadLine());
			Console.Write("- getal 2: ");
			int getal2 = int.Parse(Console.ReadLine());
			
			//wisselen van getal
			if (getal1 > getal2)
			{
				int tmp = getal1;
				getal1 = getal2;
				getal2 = tmp;
			}
			
			//bepalen van kleinste getal
			int ondergrens = getal1;
			int bovengrens = getal2;
			
			//random getal kiezen (ondergrens +1 is voor een getal tussen de ondergrens)
			Random rnd = new Random();
			int geheimGetal = rnd.Next(ondergrens +1, bovengrens );
			
			Console.WriteLine($"Even denken... ja, ik heb een getal tussen {ondergrens} en {bovengrens} in mijn hoofd.");
			Console.Write("Doe een gok: ");
			int gok = int.Parse(Console.ReadLine());
			
			//juist raden van het getal
			if (gok == geheimGetal)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("JUIST");
			}
			//fout raden van het getal
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("FOUT");
				
				//bij het fout raden van het getal en verschil niet meer is als 2
				if (Math.Abs(gok - geheimGetal) <= 2)
				{
					Console.ResetColor();
					Console.WriteLine("Je zat er nochtans niet ver af!");
				}
			}
			Console.ResetColor();
			Console.ReadKey();
		}
	}
}

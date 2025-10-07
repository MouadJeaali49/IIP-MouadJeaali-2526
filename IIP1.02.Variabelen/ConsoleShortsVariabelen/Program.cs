/* Dit is een reeks korte oefeningen over variabelen in C#. 
 * 
 * Doel van de oefeningen (theorie zie https://rogiervdl.github.io/CS-course/02_variabelen.html):
 *  
 * 1. variabelen declareren en gebruiken
 * 2. constanten declareren en gebruiken
 * 3. types string, char, bool, double en int
 * 4. ternaire operator, zie https://rogiervdl.github.io/CS-course/03_selecties.html#ternaire-operator
 *
 * Tips en richtlijnen
 * - gebruik bij uitvoer zoveel mogelijk string interpolatie, dus Console.WriteLine($"Hallo, {naam}"); en niet  Console.WriteLine("Hallo, " + naam);
 * - lees goed de richtlijnen bij elke opgave
 * - controleer bij uitvoeren of je resultaat exact overeenkomt met voorbeelduitvoer.jpg
 * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        #region DEEL A: Basisvariabelen en eenvoudige output

		/* --- Oefening A.1: Eerste variabelen ---
		 * Context: Je helpt een leraar bij te houden wie de beste score heeft.
		 * De leraar wil de naam en de score van een student opslaan.
		 *
		 * Opdracht:
		 * 1. Declareer een variabele van het type 'string' genaamd 'naamStudent' en geef deze de waarde "Sarah".
		 * 2. Declareer een variabele van het type 'int' genaamd 'studentScore' en geef deze de waarde 85.
		 * 3. Gebruik Console.WriteLine() om beide variabelen op een aparte regel af te drukken.
		 *
		 * Verwachte output:
		 * Sarah
		 * 85
		 */
		Console.WriteLine("\n\nOefening A.1: Eerste variabelen\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening A.2: Favoriete kleur en leeftijd ---
		 * Context: Je schrijft een klein programma dat je eigen favoriete kleur en leeftijd weergeeft.
		 *
		 * Opdracht:
		 * 1. Declareer een variabele 'favorieteKleur' van het type 'string' en wijs er een waarde aan toe.
		 * 2. Declareer een variabele 'leeftijd' van het type 'int' en wijs er een waarde aan toe.
		 * 3. Print een zin uit die beide variabelen gebruikt.
		 *
		 * Verwachte output:
		 * Mijn favoriete kleur is blauw en ik ben 22 jaar oud.
		 */
		Console.WriteLine("\n\nOefening A.2: Favoriete kleur en leeftijd\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening A.3: Productgegevens ---
		 * Context: Je houdt de prijs van een product bij. Prijzen kunnen decimalen hebben.
		 *
		 * Opdracht:
		 * 1. Declareer een variabele 'productNaam' van het type 'string' en geef deze de waarde "Laptop".
		 * 2. Declareer een variabele 'productPrijs' van het type 'double' en geef deze de waarde 1250.75.
		 * 3. Print de productnaam en prijs duidelijk af.
		 *
		 * Verwachte output:
		 * Product: Laptop
		 * Prijs: 1250.75 euro
		 */
		Console.WriteLine("\n\nOefening A.3: Productgegevens\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening A.4: Variabele hergebruiken ---
		 * Context: Je telt het aantal bezoekers op een website. Na een uur wil je dit aantal aanpassen.
		 *
		 * Opdracht:
		 * 1. Declareer een 'int' variabele genaamd 'aantalBezoekers' en initialiseer deze met 100.
		 * 2. Print de beginwaarde af.
		 * 3. Wijs een nieuwe waarde (bijvoorbeeld 150) toe aan dezelfde variabele.
		 * 4. Print de nieuwe waarde af.
		 *
		 * Verwachte output:
		 * Begin aantal bezoekers: 100
		 * Nieuw aantal bezoekers: 150
		 */
		Console.WriteLine("\n\nOefening A.4: Variabele hergebruiken\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening A.5: Karakter en status ---
		 * Context: Je houdt de status van een bestelling bij. Dit kan "verzonden", "geannuleerd" of "in behandeling" zijn.
		 *
		 * Opdracht:
		 * 1. Declareer een 'char' variabele 'bestelStatus' en geef deze de waarde 'V'.
		 * 2. Declareer een 'bool' variabele 'isVerzonden' en geef deze de waarde 'true'.
		 * 3. Declareer een 'string' variabele 'bestelID' en geef deze de waarde "ABC1234".
		 * 4. Print de drie variabelen af.
		 *
		 * Verwachte output:
		 * Bestel-ID: ABC1234
		 * Statuscode: V
		 * Is verzonden: True
		 */
		Console.WriteLine("\n\nOefening A.5: Karakter en status\n------------\n");
		// TODO: implementeer hier
		// ...

		#endregion

		#region DEEL B: Invoer en combinaties

		/* --- Oefening B.1: Gebruikersgegevens ---
		 * Context: Je wilt de naam en woonplaats van een gebruiker vragen en tonen in een zin.
		 *
		 * Opdracht:
		 * 1. Vraag de gebruiker om hun naam en sla deze op.
		 * 2. Vraag de gebruiker om hun woonplaats en sla deze op.
		 * 3. Print een zin met beide gegevens.
		 *
		 * Verwachte output:
		 * Input: Frank / Brussel
		 * Output: Welkom, Frank uit Brussel!
		 */
		Console.WriteLine("\n\nOefening B1: Gebruikersgegevens\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening B.2: Bioscoop uitnodiging ---
		 * Context: Je organiseert een bioscoopavond en wilt een uitnodiging sturen.
		 *
		 * Opdracht:
		 * 1. Vraag de filmnaam en sla deze op.
		 * 2. Vraag de gastnaam en sla deze op.
		 * 3. Declareer een constante 'BioscoopLocatie' = "Kinepolis".
		 * 4. Print een uitnodiging.
		 *
		 * Verwachte output:
		 * Beste Peter, je bent uitgenodigd voor de film Star Wars bij Kinepolis.
		 */
		Console.WriteLine("\n\nOefening B.2: Bioscoop uitnodiging\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening B.3: Booleaanse vlag en status ---
		 * Context: Je maakt een programma dat bijhoudt of een lamp aan of uit is en wat de kleur is.
		 *
		 * Opdracht:
		 * 1. Declareer een 'bool' variabele 'isAan' = true.
		 * 2. Declareer een 'string' variabele 'lampKleur' = "geel".
		 * 3. Print een zin die de status en kleur van de lamp weergeeft.
		 *
		 * Verwachte output:
		 * De lamp is aan en heeft de kleur geel.
		 */
		Console.WriteLine("\n\nOefening B.3: Booleaanse vlag en status\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening B.4: Constante groet ---
		 * Context: Je wilt een vaste groet gebruiken in je programma.
		 *
		 * Opdracht:
		 * 1. Declareer een 'const string' genaamd 'Groet' = "Hallo".
		 * 2. Vraag de gebruiker om hun naam.
		 * 3. Print een gepersonaliseerde groet.
		 *
		 * Verwachte output:
		 * Input: Marie
		 * Output: Hallo, Marie!
		 */
		Console.WriteLine("\n\nOefening B.4: Constante groet\n------------\n");
		// TODO: implementeer hier
		// ...

		/* --- Oefening B.5: Restaurantbestelling ---
		 * Context: Je maakt een eenvoudig programma voor een bestelling in een restaurant.
		 *
		 * Opdracht:
		 * 1. Vraag de gebruiker naar hun gerecht.
		 * 2. Vraag de gebruiker naar hun drankje.
		 * 3. Declareer een constante 'BedanktBoodschap' = "Eet smakelijk!".
		 * 4. Print een samenvatting van de bestelling en de bedankboodschap.
		 *
		 * Verwachte output:
		 * Je bestelling: Pasta en Cola.
		 * Eet smakelijk!
		 */
		Console.WriteLine("\n\nOefening B.5: Restaurantbestelling\n------------\n");
		// TODO: implementeer hier
		// ...

		#endregion
    }
}

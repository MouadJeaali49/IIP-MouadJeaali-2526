using System;
using System.Text;

/* Welkom! 
 * Hieronder vind je een reeks basisoefeningen over de principes van C#.
 * Gebruik bij uitvoer overal string interpolatie, dus Console.WriteLine($"Hallo, {naam}"); en niet  Console.WriteLine("Hallo, " + naam);
 */

namespace DrillOefeningen01Basis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            #region DEEL A: uitvoer

            /* --- Oefening A.1: tekst afdrukken --- 
             * 
             * Context: Je wilt een eenvoudige boodschap afdrukken.
             *
             * Opdracht:
             * 1. Gebruik `Console.WriteLine()` om "Welkom in de wereld van C#!" af te drukken.
             *
             * Verwachte uitvoer:
             * Welkom in de wereld van C#!
             */
            Console.WriteLine("\n\nOefening A.1: tekst afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine("Welkom in de wereld van C#!");

            /* --- Oefening A.2: meerdere regels afdrukken ---
             * Context: Je wilt de regels van een gedicht afdrukken, elke regel op een nieuwe lijn.
             *
             * Opdracht:
             * Gebruik meerdere `Console.WriteLine()` statements om het volgende gedicht af te drukken:
             * Fouten zijn rood,
             * Variabelen zijn blauw,
             * Ik werk aan de code,
             * Waar ik zo van hou.
             *
             * Verwachte uitvoer:
             * Fouten zijn rood,
             * Variabelen zijn blauw,
             * Ik werk aan de code,
             * Waar ik zo van hou.
             */
            Console.WriteLine("\n\nOefening A.2: meerdere regels afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine("Fouten zijn rood");
            Console.WriteLine("Variabelen zijn blauw");
            Console.WriteLine("Ik werk aan de code");
            Console.WriteLine("Waar ik zo van hou.");

            /* --- Oefening A.3: meerdere teksten naast en onder elkaar afdrukken ---
             * Context: Druk een korte zin af en daarna een lijst van items op nieuwe lijnen.
             *
             * Opdracht:
             * 1. Gebruik `Console.WriteLine()` om "Boodschappenlijst:" af te drukken.
             * 2. Gebruik `Console.WriteLine()` voor "Melk" op de volgende lijn.
             * 3. Gebruik `Console.Write()` voor "Brood" op de volgende lijn, gevolgd door een spatie.
             * 4. Gebruik `Console.WriteLine()` voor "Kaas" op dezelfde lijn.
             *
             * Verwachte uitvoer:
             * Boodschappenlijst:
             * Melk
             * Brood Kaas
             */
            Console.WriteLine("\n\nOefening A.3: meerdere teksten naast en onder elkaar afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine("Boodschappenlijst:");
            Console.WriteLine("Melk");
            Console.Write("Brood ");
            Console.WriteLine("Kaas");

            /* --- Oefening A.4: multiline strings ---
             * Context: Je wil een tekst van meerdere regels afdrukken in één regel.
             *
             * Opdracht:
             * 1. Gebruik `@""` om volgende tekst af te drukken in één regel:
             *      ___   
             *     (o o)  
             *    (  V  ) 
             * -----m-m----
             *
             * Verwachte uitvoer:
             *      ___   
             *     (o o)  
             *    (  V  ) 
             * -----m-m----
             */
            Console.WriteLine("\n\nOefening A.4: multiline strings\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine(@"     ___   
    (o o)  
   (  V  ) 
-----m-m----");

            #endregion

            #region DEEL B: invoer

            /* --- Oefening B.1: tekst inlezen en afdrukken ---
             * 
             * Context: Vraag de gebruiker om hun naam en druk een welkomstboodschap af.
             *
             * Opdracht:
             * 1. Gebruik `Console.Write()` om de tekst "Voer je naam in: " af te drukken.
             * 2. Lees de invoer van de gebruiker in met `Console.ReadLine()` en sla deze op in een `string` variabele `invoerNaam`.
             * 3. Druk een welkomstboodschap af, bijv. "Hallo, Reda!".
             *
             * Invoer: Reda
             * Verwachte uitvoer:
             * Voer je naam in: Reda
             * Hallo, Reda!
             */
            Console.WriteLine("\n\nOefening B.1: tekst inlezen en afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.Write("Voer je naam in: ");
            string invoerNaam = Console.ReadLine();
            Console.WriteLine($"Hallo, {invoerNaam}!");

            /* --- Oefening B.2: tekst inlezen en meermaals afdrukken ---
             * 
             * Context: Vraag de gebruiker om een tekst en druk het meermaals af.
             *
             * Opdracht:
             * 1. Druk de tekst "Welkom in de echoput" af
             * 1. Gebruik `Console.Write()` om de tekst "Zeg iets: " af te drukken.
             * 2. Lees de invoer van de gebruiker in met `Console.ReadLine()` en sla deze op in een `string` variabele `invoerTekst`.
             * 3. Druk de tekst drie keer naast elkaar af".
             *
             * Invoer: dag leo!
             * Verwachte uitvoer:
             * Zeg iets: dag leo!
             * dag leo! dag leo! dag leo!
             */
            Console.WriteLine("\n\nOefening B.2: tekst inlezen en meermaals afdrukken\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine("Welkom in de echoput");
            Console.Write("Zeg iets: ");
            string invoerTekst = Console.ReadLine();
            Console.WriteLine($"{invoerTekst} {invoerTekst} {invoerTekst}");

            #endregion

            #region DEEL C: variabelen declareren

            /* --- Oefening C.1: variabele declareren (tekst) --- 
             * 
             * Context: Je wilt je favoriete film opslaan in een variabele.
             *
             * Opdracht:
             * 1. Declareer een `string` variabele genaamd `favorieteFilm` met als waarde de titel van je favoriete film.
             * 2. Gebruik `Console.WriteLine()` om de variabele af te drukken.
             *
             * Verwachte uitvoer:
             * The Matrix
             */
            Console.WriteLine("\n\nOefening C.1: variabele declareren (tekst)\n------------\n");
            // TODO: implementeer hier.
            string favorieteFilm = "The Matrix";
            Console.WriteLine(favorieteFilm);

            /* --- Oefening C.2: variabele declareren (geheel getal) --- 
             * 
             * Context: Je wilt het aantal lessen dat je hebt gevolgd opslaan.
             *
             * Opdracht:
             * 1. Declareer een `int` variabele genaamd `aantalLessen` met als waarde een geheel getal, bijv. 6.
             * 2. Gebruik `Console.WriteLine()` om de variabele af te drukken.
             *
             * Verwachte uitvoer:
             * 6
             */
            Console.WriteLine("\n\nOefening C.2: variabele declareren (geheel getal)\n------------\n");
            // TODO: implementeer hier.
            int aantalLessen = 3;
            Console.WriteLine(aantalLessen);

            /* --- Oefening C.3: variabele declareren (karakter) --- 
             * 
             * Context: Je wilt je eerste initiaal als karakter opslaan.
             *
             * Opdracht:
             * 1. Declareer een `char` variabele genaamd `eersteInitiaal`, met als waarde een enkel karakter.
             * 2. Gebruik `Console.WriteLine()` om de variabele af te drukken.
             *
             * Verwachte uitvoer:
             * J
             */
            Console.WriteLine("\n\nOefening C.3: variabele declareren (karakter)\n------------\n");
            // TODO: implementeer hier.
            char eersteInitiaal = 'J';
            Console.WriteLine(eersteInitiaal);

            /* --- Oefening C.4: variabele declareren (karakter vs. tekst) --- 
             * Context: Druk een enkel karakter en een tekst af.
             *
             * Opdracht:
             * 1. Declareer een `char` variabele `letter` met de waarde 'A'.
             * 2. Declareer een `string` variabele `woord` met de waarde "Appel".
             * 3. Druk beide variabelen af op een aparte regel.
             *
             * Verwachte uitvoer:
             * A
             * Appel
             */
            Console.WriteLine("\n\nOefening C.4: variabele declareren (karakter vs. tekst)\n------------\n");
            // TODO: implementeer hier.
            char letter = 'A';
            string woord = "Appel";
            Console.WriteLine(letter);
            Console.WriteLine(woord);

            #endregion

            #region DEEL D: waarden opnieuw toewijzen aan variabelen

            /* --- Oefening D.1: waarde veranderen van een variabele (tekst) --- 
             * 
             * Context: Je wilt de status van een taak bijhouden. De status kan veranderen.
             *
             * Opdracht:
             * 1. Declareer een `string` variabele `status` en geef deze de waarde "in behandeling".
             * 2. Druk de `status` af.
             * 3. Wijs een nieuwe waarde, "afgerond", toe aan dezelfde variabele.
             * 4. Druk de `status` opnieuw af.
             *
             * Verwachte uitvoer:
             * in behandeling
             * afgerond
             */
            Console.WriteLine("\n\nOefening D.1: waarde veranderen van een variabele (tekst)\n------------\n");
            // TODO: implementeer hier.
            string status = "in behandeling";
            Console.WriteLine(status);
            status = "afgerond";
            Console.WriteLine(status);

            /* --- Oefening D.2: waarde veranderen van een variabele (geheel getal) ---
             * Context: De score van een speler kan veranderen tijdens een spel.
             *
             * Opdracht:
             * 1. Declareer een `int` variabele `score` en geef deze de waarde 10.
             * 2. Druk de `score` af.
             * 3. Verander de waarde `score` naar 50.
             * 4. Druk de `score` opnieuw af.
             *
             * Verwachte uitvoer:
             * 10
             * 50
             */
            Console.WriteLine("\n\nOefening D.2: waarde veranderen van een variabele (geheel getal)\n------------\n");
            // TODO: implementeer hier.
            int score = 10;
            Console.WriteLine(score);
            score = 50;
            Console.WriteLine(score);

            /* --- Oefening D.3: waarde optellen bij variabele (geheel getal) ---
             * Context: De score van een speler kan veranderen tijdens een spel.
             *
             * Opdracht:
             * 1. Declareer een `int` variabele `resultaat` en geef deze de waarde 50.
             * 2. Druk de `resultaat` af.
             * 3. Tel 7 op bij deze variabele
             * 4. Druk de `resultaat` opnieuw af.
             *
             * Verwachte uitvoer:
             * 50
             * 57
             */
            Console.WriteLine("\n\nOefening D.3: waarde optellen bij variabele (geheel getal)\n------------\n");
            // TODO: implementeer hier.
            int resultaat = 50;
            Console.WriteLine(resultaat);
            resultaat = resultaat + 7;
            Console.WriteLine(resultaat);

            /* --- Oefening D.4: variabele optellen bij een andere variabele (geheel getal) ---
             * Context: Voeg de waarde van één variabele toe aan een andere
             *
             * Opdracht:
             * 1. Declareer een `int` variabele `punten` met de waarde 40.
             * 2. Druk "Je punten: " en de punten af.
             * 3. Declareer een `int` variabele `bonus` met de waarde 7.
             * 4. Tel `bonus` op bij `punten`.
             * 5. Druk "Je punten met bonus: " en de punten af.
             *
             * Verwachte uitvoer:
             * Je totale punten: 47
             */
            Console.WriteLine("\n\nOefening D.4: variabele optellen bij een andere variabele (geheel getal)\n------------\n");
            // TODO: implementeer hier.
            int punten = 40;
            Console.WriteLine($"Je punten: {punten}");
            int bonus = 7;
            punten = punten + bonus;
            Console.WriteLine($"Je punten met bonus: {punten}");

            #endregion

            #region DEEL E: variabelen en tekst combineren

            /* --- Oefening E.1: combinatie variabelen en tekst (1) ---
             * Context: Je wilt een gepersonaliseerde uitnodiging afdrukken.
             *
             * Opdracht:
             * 1. Declareer een `string` variabele `naam` met de waarde "Marie".
             * 2. Declareer een `string` variabele `evenement` met de waarde "mijn verjaardagsfeest".
             * 3. Gebruik `Console.WriteLine()` met string-interpolatie om een zin te maken als: "Hallo Marie, je bent uitgenodigd voor mijn verjaardagsfeest!"
             *
             * Verwachte uitvoer:
             * Hallo Marie, je bent uitgenodigd voor mijn verjaardagsfeest!
             */
            Console.WriteLine("\n\nOefening E.1: combinatie variabelen en tekst (1)\n------------\n");
            // TODO: implementeer hier.
            string naam = "Marie";
            string evenement = "mijn verjaardagsfeest";
            Console.WriteLine($"Hallo {naam}, je bent uitgenodigd voor {evenement}!");

            /* --- Oefening E.2: combinatie variabelen en tekst (2) ---
             * Context: Je wilt de productnaam, prijs en de munteenheid afdrukken.
             *
             * Opdracht:
             * 1. Declareer een `string` variabele `product` met de waarde "t-shirt".
             * 2. Declareer een `int` variabele `aantalOver` met de waarde 19.
             * 3. Declareer een `char` variabele `maat` met de waarde 'M'.
             * 4. Druk een zin af met al deze variabelen, bijv. "Er zijn nog 19 t-shirts maat M over."
             *
             * Verwachte uitvoer:
             * Er zijn nog 19 t-shirts maat M over.
             */
            Console.WriteLine("\n\nOefening E.2: combinatie variabelen en tekst (2)\n------------\n");
            // TODO: implementeer hier.
            string product = "t-shirt";
            int aantaOver = 19;
            char maat = 'M';
            Console.WriteLine($"Er zijn nog {aantaOver} {product} maat {maat} over.");

            /* --- Oefening E.3: combinatie variabelen en tekst (3) ---
             * Context: Je maakt een bestelprogramma en wilt een overzicht afdrukken van een product.
             *
             * Opdracht:
             * 1. Declareer een `string` `productNaam` met de waarde "Laptop".
             * 2. Declareer een `int` variabele `aantal` met de waarde 1.
             * 3. Declareer een `int` variabele `prijs` met de waarde 1200.
             * 4. Druk een samenvatting van de bestelling af met alle variabelen.
             *
             * Verwachte uitvoer (voorbeeld):
             * Product: Laptop
             * Aantal: 1
             * Prijs: 1200 euro
             */
            Console.WriteLine("\n\nOefening E.3: combinatie variabelen en tekst (3)\n------------\n");
            // TODO: implementeer hier.
            string productNaam = "Laptop";
            int aantal = 1;
            int prijs = 1200;
            Console.WriteLine($"Product: {productNaam}");
            Console.WriteLine($"Aantal: {aantal}");
            Console.WriteLine($"Prijs per stuk: €{prijs}");
            Console.WriteLine($"Totaal: €{aantal * prijs}");

            /* --- Oefening E.4: combinatie variabelen en tekst (4) ---
             * Context: Je wilt een profiel met verschillende datatypes afdrukken.
             *
             * Opdracht:
             * 1. Declareer een `string` `gebruikersnaam` met de waarde "Jan".
             * 2. Declareer een `int` `geboortejaar` met de waarde 2000.
             * 3. Declareer een `char` `geslacht` met de waarde 'M'.
             * 4. Declareer een `int` `lengte` met de waarde 185.
             * 5. Druk alle variabelen af in een leesbaar formaat op aparte regels
             * -> uitdaging: combineer een multiline string met interpolatie om alles met één Console.Writeline($@"...") af te drukken
             *
             * Verwachte uitvoer:
             * Naam: Jan
             * Geboortejaar: 2000
             * Geslacht: M
             * Lengte: 185 cm
             */
            Console.WriteLine("\n\nOefening E.4: combinatie variabelen en tekst (4n------------\n");
            // TODO: implementeer hier.
            string gebruikersnaam = "Jan";
            int geboortejaar = 2000;
            char geslacht = 'M';
            int lengte = 185;
            Console.WriteLine($@"
Naam: {gebruikersnaam}
Geboortejaar: {geboortejaar}
Geslacht: {geslacht}
Lengte: {lengte} cm");

            #endregion

            #region DEEL F: escaping en speciale karakters

            /* --- Oefening F.1: escaping - aanhalingstekens ---
             * Context: Je wilt een beroemde quote afdrukken die zelf aanhalingstekens bevat.
             *
             * Opdracht:
             * 1. Declareer een tekstvariabele `quote`.
             * 2. Wijs de volgende tekst toe: Hij zei: "Hallo Wereld!". Zorg ervoor dat de aanhalingstekens correct worden weergegeven.
             * 3. Druk de variabele af.
             *
             * Verwachte uitvoer:
             * Hij zei: "Hallo Wereld!"
             */
            Console.WriteLine("\n\nOefening F.1: escaping - aanhalingstekens\n------------\n");
            // TODO: implementeer hier.
            string quote = "Hij zei: \"Hallo Wereld!\"";
            Console.WriteLine(quote);

            /* --- Oefening F.2: Escaping - tabs en newlines ---
             * Context: Je wilt een korte, gestructureerde lijst afdrukken met één enkel `Console.WriteLine` statement.
             *
             * Opdracht: 
             * 1. gebruik `\t` voor een tab en `\n` om de volgende lijst in één opdracht af te drukken:
             * Cursussen:
             *     C#
             *     HTML
             *     Javascript
             *
             * Verwachte uitvoer:
             * Cursussen:
             *     C#
             *     HTML
             *     Javascript
             */
            Console.WriteLine("\n\nOefening F.2: Escaping - tabs en newlines\n------------\n");
            // TODO: implementeer hier.
            string lijst = "Cursussen:\n\tC#\n\tHTML\n\tJavascript";
            Console.WriteLine(lijst);

            /* --- Oefening F.3: UTF-8 - Symbolen ---
             * Context: Je wilt speciale symbolen zoals het copyright- of euroteken correct weergeven in de console.
             *
             * Opdracht:
             * 1. Stel de `OutputEncoding` van de Console in op `UTF8` (let op: dit moet de allereerste opdrachtregel zijn, helemaal bovenaan deze oefeningen!).
             * 2. Druk de volgende twee regels af met één enkele Console.WriteLine();
             * Prijs: €25 
             * ©2024"
             *
             * Verwachte uitvoer:
             * Prijs: €25 
             * ©2024
             */
            Console.WriteLine("\n\nOefening F.3: UTF-8 - Symbolen\n------------\n");
            // TODO: implementeer hier.
            Console.WriteLine("Prijs: €25\n©2024");

            /* --- Oefening F.4: UTF-8 - andere talen ---
             * Context: Je applicatie moet overweg kunnen met karakters uit andere talen.
             *
             * Opdracht:
             * 1. Declareer een variabele `dessert` met de tekst "crème brûlée".
             * 2. Druk de variabele af.
             *
             * Verwachte uitvoer:
             * crème brûlée
             */
            Console.WriteLine("\n\nOefening F.4: UTF-8 - andere talen \n------------\n");
            // TODO: implementeer hier.
            string dessert = "crème brûlée";
            Console.WriteLine(dessert);

            /* --- Oefening F.5: UTF-8 - emoji's ---
             * Context: je applicatie moet emoji's kunnen lezen en schrijven
             *
             * Opdracht:
             * 1. Stel nu ook de `InputEncoding` van de Console in op `UTF8` (let op: dit moet ook helemaal bovenaan staan, net zoals OutputEncoding!)
             * 2. Druk de tekst "Geef je favoriete emoji: " af
             * 3. Laat de gebruiker een emoji ingeven; bewaar het in een variabele `emoji`.
             * 4. Druk de ingelezen emoji 5 keer naast elkaar af.
             *
             * Invoer: 😍
             * Verwachte uitvoer:
             * Geef je favoriete emoji: 😍
             * 😍😍😍😍😍
             */
            Console.WriteLine("\n\nOefening F.5: UTF-8 - emoji's \n------------\n");
            // TODO: implementeer hier.
            Console.Write("Geef je favoriete emoji: ");
            string emoji = Console.ReadLine();
            Console.WriteLine($"{emoji}{emoji}{emoji}{emoji}{emoji}");

            #endregion

            #region DEEL G: console kleuren

            /* --- Oefening G.1: Console Kleuren - Voorgrond ---
             * Context: Je wilt feedback geven aan de gebruiker met kleuren. Een succesbericht in het groen en een foutmelding in het rood.
             *
             * Opdracht:
             * 1. Zet de tekstkleur van de console op groen.
             * 2. Druk de tekst "Ok: tekst gekopieerd." af.
             * 3. Zet de tekstkleur van de console op rood.
             * 4. Druk de tekst "Fout: doelbestand niet gevonden." af.
             * 5. Reset de consolekleur naar de standaardwaarde.
             * 6. Druk de tekst "Einde script." af.
             *
             * Verwachte uitvoer (in de juiste kleuren):
             * Ok: tekst gekopieerd.
             * Fout: doelbestand niet gevonden.
             * Einde script.
             */
            Console.WriteLine("\n\nOefening G.1: Console Kleuren - Voorgrond\n------------\n");
            // TODO: implementeer hier.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ok: tekst gekopieerd.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fout: doelbestand niet gevonden.");
            Console.ResetColor();
            Console.WriteLine("Einde script.");

            /* --- Oefening G.2: Console Kleuren - Achtergrond ---
             * Context: Je wilt een belangrijke waarschuwing afdrukken die extra opvalt door een andere achtergrondkleur.
             *
             * Opdracht:
             * 1. Zet de achtergrondkleur op `DarkBlue`.
             * 2. Zet de voorgrondkleur (tekstkleur) op `Yellow`.
             * 3. Druk de tekst "WAARSCHUWING: Systeem wordt over 5 minuten herstart." af.
             * 4. Reset de consolekleuren.
             * 5. Druk een lege regel af.
             * 6. Druk de tekst "druk een toets om nu te herstarten".
             *
             * Verwachte uitvoer (met de juiste voor- en achtergrondkleur):
             * WAARSCHUWING: Systeem wordt over 5 minuten herstart.
             * druk een toets om nu te herstarten
             */
            Console.WriteLine("\n\nOefening G.2: Console Kleuren - Achtergrond\n------------\n");
            // TODO: implementeer hier.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WAARSCHUWING: Systeem wordt over 5 minuten herstart.");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("druk een toets om nu te herstarten");

            #endregion

        }
    }
}

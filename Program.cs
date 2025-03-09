using System;
using Opgave_2_øvelse_2;

class Program
{
    private static string fuelType;
    private static bool isEngineOn;

    static void Main(string[] args)
    {


        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Indsamler bilens oplysninger
        Console.Write("Indtast bilmærke: ");
        string bilmærke = Console.ReadLine();

        Console.Write("Indtast bilmodel: ");
        string bilmodel = Console.ReadLine();

        Console.Write("Indtast årgang: ");
        if (!int.TryParse(Console.ReadLine(), out int årgang))
        {
            Console.WriteLine("Fejl: Årgang skal være et tal!");
            return;
        }

        Console.Write("Indtast bilens geartype: ");
        string geartype = Console.ReadLine();

        Console.Write("Indtast km-stand: ");
        double km = Convert.ToDouble(Console.ReadLine());


        // Indhenter om motoren er tændt
        Console.Write("Er motoren tændt? (ja/nej): ");
        string motorStatus = Console.ReadLine().ToLower();
        isEngineOn = motorStatus == "ja"; // Tildeler en bool værdi baseret på brugerens input


        Console.Write("Indtast km/L: ");
        double kmPrLiter = Convert.ToDouble(Console.ReadLine());

        // Opret bilobjekt med constructor
        Class1 minBil = new Class1(bilmærke, bilmodel, årgang, km, kmPrLiter, isEngineOn, geartype, fuelType);

        // Indhenter brændstoftype
        Console.Write("Indtast brændstoftype (benzin/diesel): ");
        string? input = Console.ReadLine();
        string brændstoftype = input != null ? input.ToLower() : "";

        // Viser de indtastede oplysninger
        Console.WriteLine($"\nBilmærke: {bilmærke}, Model: {bilmodel}, Årgang: {årgang}, Geartype: {geartype}, Brændstoftype: {fuelType}\n");
        Console.ReadLine();
        
        // Udskriver om motoren er tændt
        Console.WriteLine($"Motoren er tændt: {minBil.GetIsEngineOn()}");  // Hvis motoren er tændt, vil det vise 'true'
        
        // Indhenter afstand på en tankfuld
        Console.Write("Indtast afstand i km på en tankfuld: ");

        if (!int.TryParse(Console.ReadLine(), out int distanceTankfuld))
        {
            Console.WriteLine("Fejl: Indtast kun tal!");
            return;
        }
        Console.ReadLine();


        // Beregner brændstofforbrug og pris
        double forbrug = (double)distanceTankfuld / kmPrLiter;
        double benzinpris = 13.49;
        double dieselpris = 12.29;
        double brændstofudgift = 0;

        if (brændstoftype == "benzin")
        {
            brændstofudgift = forbrug * benzinpris;
            Console.WriteLine($"Bilens benzinforbrug koster ca. {brændstofudgift:F2} kr.");
        }
        else if (brændstoftype == "diesel")
        {
            brændstofudgift = forbrug * dieselpris;
            Console.WriteLine($"Bilens dieselforbrug koster ca. {brændstofudgift:F2} kr.");
        }
        else
        {
            Console.WriteLine("Fejl: Ugyldig brændstoftype.");
            return;
        }
        Console.ReadLine();
        
        // Kilometerstand før opdatering
        int afstandPåBilen = 122376;
        Console.WriteLine($"Bilen har kørt: {afstandPåBilen} km.");
        Console.ReadLine();
        
        // Opdaterer kilometerstand
        int kørteKilometer = afstandPåBilen + distanceTankfuld;
        Console.WriteLine($"Opdateret kilometerstand: {kørteKilometer} km.\n");
        Console.ReadLine();
        
        // Indtastning af køreturens afstand
        Console.Write("Indtast afstand i km på en køretur: ");
        if (!int.TryParse(Console.ReadLine(), out int køretur))
        {
            Console.WriteLine("Fejl: Indtast kun tal!");
            return;
        }
        Console.ReadLine();
        // Beregner brændstofudgifter for køreturen
        double brændstofudgifterBenzin = køretur * benzinpris;
        double brændstofudgifterDiesel = køretur * dieselpris;

        // Opgave 2.1 - Oprettelse af en tekststreng med udgifter
        string tekst = $"\nBrændstofudgifterne for benzin er i kr.: {brændstofudgifterBenzin:F2}" +
                       $"\nBrændstofudgifterne for diesel er i kr.: {brændstofudgifterDiesel:F2}" +
                       $"\nFor kørte {køretur} km.";

        Console.WriteLine(tekst); // Udskriver brændstofudgifter
        Console.ReadLine();

        // Udskriver om motoren er tændt
        Console.WriteLine(minBil.GetIsEngineOn());  // Hvis motoren er tændt, vil det vise 'true'


    }
}

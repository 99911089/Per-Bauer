using System;
namespace Opgave_2_øvelse_2;

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


        // Indhenter brændstoftype
        Console.Write("Indtast brændstoftype (benzin/diesel): ");
        string fuelType = Console.ReadLine()?.ToLower() ?? "";  // Hvis motoren er tændt, vil det vise 'true'

        // Opret bilobjekt med constructor
        // Opretter Car-objekt
        Class1 minBil = new Class1(bilmærke, bilmodel, årgang, km, kmPrLiter, isEngineOn, geartype, fuelType);



        // Viser de indtastede oplysninger
        Console.WriteLine($"\nBilmærke: {bilmærke}, Model: {bilmodel}, Årgang: {årgang}, Geartype: {geartype}, Brændstoftype: {fuelType}\n");
        Console.ReadLine();


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

        while (true)
        {
            Console.WriteLine("\nVælg en handling:");
            Console.WriteLine("1. Kør en tur");
            Console.WriteLine("2. Beregn turpris");
            Console.WriteLine("3. Vis bilens oplysninger");
            Console.WriteLine("4. Afslut");
            Console.Write("Indtast valg: ");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    Console.Write("Indtast distance i km: ");
                    if (double.TryParse(Console.ReadLine(), out double distance))
                    {
                        minBil.Drive(distance);
                    }
                    else
                    {
                        Console.WriteLine("Fejl: Indtast kun tal!");
                    }
                    break;

                case "2":
                    Console.Write("Indtast distance i km: ");
                    if (double.TryParse(Console.ReadLine(), out double tripDistance))
                    {
                        Console.Write("Indtast brændstofpris pr. liter: ");
                        if (double.TryParse(Console.ReadLine(), out double literPrice))
                        {
                            double tripCost = minBil.CalculateTripPrice(tripDistance, literPrice);
                            Console.WriteLine($"Turen vil koste ca. {tripCost:F2} kr.");
                        }
                        else
                        {
                            Console.WriteLine("Fejl: Indtast kun tal for brændstofprisen!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Fejl: Indtast kun tal for distancen!");
                    }
                    break;

                case "3":
                    minBil.PrintCarDetails();
                    break;

                case "4":
                    Console.WriteLine("Programmet afsluttes...");
                    return;

                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }
        }
    }
}

using System;
using CarApp_finally;




class Program
{
    private static object kmprliter;
    public static string bilmærke;
    public static string bilmodel;
    public static string årgang;
    public static object A { get; private set; }
    public static object M { get; private set; }


    static void Main(string[] args)
    {


        // Console.ReadKey(); //Holder konsollen åben efter menuen

        Console.WriteLine("Indtast bilmærke");
        string bilmærke = Console.ReadLine();

        Console.WriteLine("indtast bilmodel");
        string bilmodel = Console.ReadLine();

        Console.WriteLine("Indtast farve");
        string farve = Console.ReadLine();

        Console.WriteLine("Indtast Årgang på bilen");
        string årgang = Console.ReadLine();

        Console.ReadLine();

        string input = ""; // Konvertere input til et tal men er en tom streng og bliver oprettet til en variabel input osv.
        int number = string.IsNullOrWhiteSpace(input) ? 0 : Convert.ToInt32(input); // Hvis betingelsen string.IsNullOrWhiteSpace(input) er true, bliver number sat til 0.
                                                                                    // Hvis betingelsen er false, udføres Convert.ToInt32(input), som konverterer værdien af input til et heltal.
                                                                                    // Hvis input ikke er tom, bliver den konverteret til et heltal.
        Console.WriteLine("Indtast bilens geartype");
        string geartype = Console.ReadLine();
        if (!string.IsNullOrEmpty(geartype)) // Sikrer, at inputtet ikke er tomt

        {
            char bogstav = geartype[0]; // Tager det første tegn
            Console.WriteLine($"{A} {M}");
        }

        // Opgave 1 Bilens brændstoftype er: {brændstoftype}, Bilens brændstof forbrug er: {resultat},

        Console.WriteLine($"Bilmærke er: {bilmærke}, Bilmodel er: {bilmodel}, Bilfarve er:{farve}, Bilens årgang er:{årgang}, Bilens geartype er: {geartype}");
        Console.ReadLine();

        Console.WriteLine("Indtast brændstoftype benzin eller diesel");
        string brændstoftype = Console.ReadLine();


        Console.WriteLine("Indtast afstand i km på en tankfuld");
        string afstand = Console.ReadLine();

        int number1;

        if (int.TryParse(afstand, out number1))
        {
            Console.WriteLine($"Du indtastede km afstand: {number1}");  // Udskriver tallet
        }

        Console.WriteLine("Indtast km/L");
        string kml = Console.ReadLine();
        int number2;

        if (int.TryParse(kml, out number2))
        {
            Console.WriteLine($"Du indtastede : {number2}");  // Udskriver tallet
        }

        double resultat = number1 / number2;

        // Console.WriteLine(resultat); 

        double benzinpris = 13.49;
        double dieselpris = 12.29;
        double brændstofBenzin = resultat * benzinpris;
        Console.WriteLine($"Bilens Benzin forbrug er: {brændstofBenzin}");
        string afstandPåBilen = "122376";
        int afstandPåBilen3 = int.Parse(afstandPåBilen);
        Console.WriteLine();

        //int afstandPåBilen = 122376;
        Console.WriteLine($"Bilen har kørt: {afstandPåBilen} Km");
        Console.ReadLine();
        double brændstofdiesel = resultat * dieselpris;
        Console.ReadLine();
        Console.WriteLine($"Bilens diesel forbrug er: {brændstofdiesel}");
        int afstandPåBilen2 = 122376;
        Console.WriteLine($"Bilen har kørt: {afstandPåBilen2} Km");
        Console.ReadLine();

        // Formatér output med PadLeft og PadRight øvelse 2.2

        Console.WriteLine();
        Console.WriteLine("Biloplysninger:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Type bil".PadRight(15) + "Info om bil".PadLeft(15));
        Console.WriteLine("----------------------------");
        Console.WriteLine("Bilmærke:".PadRight(15) + bilmærke.PadLeft(15));
        Console.WriteLine("Bilmodel:".PadRight(15) + bilmodel.PadLeft(15));
        Console.WriteLine("Farve:".PadRight(15) + farve.PadLeft(15));
        Console.WriteLine("Årgang:".PadRight(15) + årgang.PadLeft(15));
        Console.WriteLine("Km/L:".PadRight(15) + kml.PadLeft(15));
        Console.WriteLine("Brændstoftype:".PadRight(15) + brændstoftype.PadLeft(15));
        Console.WriteLine("Afstand bilen har kørt:".PadRight(15) + afstandPåBilen.PadLeft(15));


        int kørteKilometer = afstandPåBilen3 + number1;                                 // Opdatere kilometerstand
        Console.WriteLine($"Bilen har kørt nu: {kørteKilometer} siden sidste påfyldning");

        // Indtaster afstand på køretur og udgifter

        Console.WriteLine("Indtast afstand i km på køretur");
        string køretur = Console.ReadLine();

        if (int.TryParse(køretur, out int distancen))

        {
            Console.WriteLine($"kørselafstand er: {distancen}");
        }
        Console.WriteLine();

        int prisforbenzin = 13;
        double brændstofudgifterbenzin = prisforbenzin * distancen;
        int prisfordiesel = 12;
        double brændstofudgifterdiesel = prisfordiesel * distancen;

        // Brug værdier i en streng Opgave 2.1 

        string tekst = $"Brændstofudgifterne for benzin er i kr.: {brændstofudgifterbenzin}\n Brændstofudgifterne for diesel er i kr.: {brændstofudgifterdiesel}\n for kørte {distancen}  km.";
        Console.WriteLine(tekst);
        Console.ReadLine();


        // Console.WriteLine("Starter programmet...");

        {

            Class1 besked = new Class1();
            besked.VisBesked(); // Viser besked og venter på tastetryk

            Console.Clear(); // Rydder skærmen efter tastetryk
            Menu menu = new Menu();   // Opretter et objekt af Menu-klassen
            Console.WriteLine("");                            
            menu.Menu1();           // Kalder Menu1-metoden
            
        }

        {
            Console.WriteLine("");
            Console.ReadKey(); // Sørger for, at vi kan se output

            Class1 class1 = new Class1(); // Opret en instans af Class1
            class1.VisBesked(); // Kalder VisBesked() først
            class1.Menu1(); // Kalder Menu1() bagefter

            Console.WriteLine("\nProgrammet afsluttes. Tryk på en tast for at lukke...");
            Console.ReadKey(); // Holder programmet åbent
        }

        Class1 class2 = new Class1();
        Console.WriteLine($"Bilmærke er: {class2.HentBilmærke()}");
        Console.WriteLine($"Bilmodel er: {class2.HentBilmodel()}");
        Console.WriteLine($"Bilårgang er: {class2.Hentårgang()}");
        Console.WriteLine($"Antal kørte km er: {class2.HentKm()}");
    }

        public class Menu
        {

            public void Menu1()  // SKAL være public, ellers kan Main ikke tilgå den
            {
                Console.WriteLine("");
                Console.ReadLine();
            }

        }

    

}














    









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp_finally
{

    public class Class1
    {


        public void Menu1()
        {

            Console.WriteLine("Velkommen til bilmenuen!");
            Console.ReadKey(); // Stopper og venter på tastetryk

            bool kørmenu = true; // Holder menuen kørende

            while (kørmenu) // Så længe true, fortsætter loopen
            {
                Console.Clear(); // Rydder konsollen for en pæn menu

                Console.WriteLine("Indtast et tal for at få biloplysninger:");
                Console.WriteLine("0 - Bilmærke");
                Console.WriteLine("1 - Bilmodel");
                Console.WriteLine("2 - Årgang");
                Console.WriteLine("3 - Afstand (km)");
                Console.WriteLine("4 - Afslut programmet");

                string input = Console.ReadLine();
                Console.WriteLine($"Biloplysninger '{input}'"); 

                if (int.TryParse(input, out int biloplysninger))
                {
                    switch (biloplysninger)
                    {
                        case 0:
                            Console.WriteLine($"\nUdskriv oplysninger på bil: Bilmærke: {bilmærke} Bilmodel: {bilmodel} Bilårgang {årgang} og har kørt {Km} km");
                            break;
                        case 1:
                            Console.WriteLine("Udskriv model på bil: Corolla");
                            break;
                        case 2:
                            Console.WriteLine("Udskriv årgang på bil: 2020");
                            break;
                        case 3:
                            Console.WriteLine("Udskriv km-tilstand på bil: 122876.50 km");
                            break;
                        case 4:
                            kørmenu = false; // Stopper menuen
                            Console.WriteLine("Afslutter programmet...");
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg, prøv igen.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Fejl: Du skal indtaste et tal.");
                }

                if (kørmenu) // Kun vis pause, hvis programmet ikke lukkes
                {
                    Console.WriteLine("\nTryk på en tast for at fortsætte...");
                    Console.ReadKey();

                }

            }

        }

        internal void VisBesked()
        {
            Console.WriteLine("");
            Console.ReadKey(); // Stopper programmet, indtil brugeren trykker en tast

        }

        private string bilmærke = "Audi";
        private string bilmodel = "A6";
        private string årgang = "2025";
        private string Km = "122876.50";
        public string HentBilmærke()
        {
            return bilmærke;
        }


        public string HentBilmodel()
        {
            return bilmodel;
        }

        public string Hentårgang()
        {
            return årgang;
        }

        public string HentKm()
        {
            return Km;
        }


    }

}

                
            
        



    











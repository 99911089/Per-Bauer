using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2_øvelse_2
{


    // Definerer en offentlig klasse ved navn Class1
    public class Class1
    {
        // Private felter (instansvariabler), der kun kan tilgås inden for denne klasse
       
        private string bilmærke; // 'private' betyder, at variablen kun kan tilgås inden for denne klasse (Class1).   
                                 // 'string' er datatypen, som bruges til at gemme tekst (i dette tilfælde bilmærket).
                                 // 'bilmærke' er navnet på variablen, som skal gemme bilens mærke (f.eks. "Toyota", "BMW").
        private string bilmodel;
        private int årgang;
        private double km;
        private double kmPerLiter;
        private bool isEngineOn;
        private string fuelType;
        private string geartype;


        // Anden konstruktør med en anden parameterliste
        public Class1(string mærke, string model, int årgang, double kilometer, double kmL, bool isEngineOn, string fuelType, string geartype)
        {
            // Tildeler parameteren 'bilmærke' til feltet 'mærke'        

            this.bilmærke = mærke;
            this.bilmodel = model;
            this.årgang = årgang;
            this.km = kilometer;
            this.kmPerLiter = kmL;
            this.isEngineOn = isEngineOn;
            this.geartype = geartype;
            this.fuelType = fuelType;

        }

        public void Drive(double distance)
        {
            if (isEngineOn)
            {
                km += distance;  // Opdaterer kilometerstand
                Console.WriteLine($"Bilen har kørt {distance} km. Ny kilometerstand: {km} km.");
            }
            else
            {
                Console.WriteLine("Fejl: Motoren er slukket. Tænd motoren for at køre.");
            }
        }

        public double CalculateTripPrice(double distance, double literPrice)
        {
            double fuelUsed = distance / kmPerLiter;
            return fuelUsed * literPrice;
        }

        public void PrintCarDetails()
        {
            Console.WriteLine("\nBilens oplysninger:");
            Console.WriteLine($"Mærke: {bilmærke}");
            Console.WriteLine($"Model: {bilmodel}");
            Console.WriteLine($"Årgang: {årgang}");
            Console.WriteLine($"Kilometerstand: {km} km");
            Console.WriteLine($"Brændstoføkonomi: {kmPerLiter} km/l");
            Console.WriteLine($"Geartype: {geartype}");
            Console.WriteLine($"Brændstoftype: {fuelType}");
            Console.WriteLine($"Motorstatus: {(isEngineOn ? "Tændt" : "Slukket")}");
        }

        // Getter til at få motorens tilstand (er motoren tændt?)
        public bool GetIsEngineOn()
        {
            return isEngineOn;
        }


    }

}
        

        
            
    

    



    


            
        










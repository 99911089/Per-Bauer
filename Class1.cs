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
        private double kmPrLiter;
        private string geartype;


        // Anden konstruktør med en anden parameterliste
        public Class1(string mærke, string model, int årgang, double kilometer, double kmL, bool isEngineOn, string fuelType1)
        {
            this.bilmærke = mærke; // Tildeler parameteren 'bilmærke' til feltet 'bilmærke'
            this.bilmodel = model;
            this.årgang = årgang;
            this.km = kilometer;
            this.kmPerLiter = kmL;
            this.isEngineOn = isEngineOn;
            this.fuelType = fuelType;
            this.geartype = geartype;
        }

        // Getter til at få motorens tilstand (er motoren tændt?)
        public bool GetIsEngineOn()
        {
            return isEngineOn;
        }


    }

}
        

        
            
    

    



    


            
        










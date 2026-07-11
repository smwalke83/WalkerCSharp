// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Gasoline.cs


using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerQ4
{
    // Gasoline class, child of EnergyTypeBase
    public class Gasoline : EnergyTypeBase
    {
        // Implementing each abstract method from the abstract parent class

        // Returns the name of the fuel type
        public override string GetName() 
        {
            return "Gasoline";    
        }

        // Returns the type of energy of the fuel type (As far as I can tell, all three of the fuels we used are Chemical fuels)
        public override string GetEnergyType()
        {
            return "Chemical";
        }

        // Returns the specific energy of the fuel type
        public override double GetSpecificEnergy()
        {
            // MJ/kg
            return 46.4;
        }

        // Returns the energy density of the fuel type
        public override double GetEnergyDensity()
        {
            // MJ/L
            return 34.2;
        }
    }
}

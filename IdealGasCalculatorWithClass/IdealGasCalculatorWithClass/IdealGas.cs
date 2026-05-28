// Programmer: Scott Walker
// Email: swalker62@cnm.edu
// Program: Ideal Gas Calculator With Class
// Purpose: Recreating the ideal gas calculator with a class containing private fields and get/set methods

// These were all added by VS
using System;
using System.Collections.Generic;
using System.Text;

// This was also added by VS, but I shortened the name of the namespace
namespace IdealGasClass
{
    class IdealGas
    {
        // Initializing private fields for ideal gas properties
        private double mass;
        private double volume;
        private double temp;
        private double molecularWeight;
        private double pressure;

        // Public getters for the private fields
        public double GetMass()
        {
            return mass;
        }

        public double GetVolume()
        {
            return volume;
        }

        public double GetTemp()
        {
            return temp;
        }

        public double GetMolecularWeight()
        {
            return molecularWeight;
        }

        public double GetPressure()
        {
            return pressure;
        }

        // Setters
        public void SetMass(double newMass)
        {
            mass = newMass;
            Calc();
        }

        public void SetVolume(double newVolume)
        {
            volume = newVolume;
            Calc();
        }

        public void SetTemp(double newTemp)
        {
            temp = newTemp;
            Calc();
        }

        public void SetMolecularWeight(double newMolecularWeight)
        {
            molecularWeight = newMolecularWeight;
            Calc();
        }

        // Pressure calculator, called when a value changes in an instance of the class
        private void Calc()
        {
            const double IDEAL_GAS_CONST = 8.3145;
            double moles =  mass / molecularWeight;
            double kelvin = temp + 273.15;
            pressure = (moles * IDEAL_GAS_CONST * kelvin) / volume;
        }
    }
}

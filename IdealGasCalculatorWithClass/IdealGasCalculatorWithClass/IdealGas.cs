using System;
using System.Collections.Generic;
using System.Text;

namespace IdealGasClass
{
    class IdealGas
    {
        private double mass;
        private double volume;
        private double temp;
        private double molecularWeight;
        private double pressure;

        // Getters
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

        private void Calc()
        {
            const double IDEAL_GAS_CONST = 8.3145;
            double moles =  mass / molecularWeight;
            double kelvin = temp + 273.15;
            pressure = (moles * IDEAL_GAS_CONST * kelvin) / volume;
        }
    }
}

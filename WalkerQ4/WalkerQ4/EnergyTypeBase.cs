// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: EnergyTypeBase.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerQ4
{

    // Abstract class - parent the the three energy types used in this program
    public abstract class EnergyTypeBase
    {
        public abstract string GetName();
        public abstract string GetEnergyType();
        public abstract double GetSpecificEnergy();
        public abstract double GetEnergyDensity();
    }
}

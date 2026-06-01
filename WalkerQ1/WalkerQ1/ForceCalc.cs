// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File Name: WalkerQ1

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerQ1
{
    public class ForceCalc
    {
        // properties
        private const double gConstant = 6.67408e-11;
        public string Object1 { get; set; }
        public string Object2 { get; set; }
        public double GForce { get; private set; }
        private double object1Mass;
        public double Object1Mass 
        {
            get { return object1Mass; }
            set { object1Mass = value; Calc(); }
        }
        private double object2Mass;
        public double Object2Mass
        {
            get { return object2Mass; }
            set { object2Mass = value; Calc(); }
        }
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; Calc(); }
        }

        // methods - one to calc gravitational force and one to return a string to report the data to the user.
        private void Calc() 
        {
            GForce = gConstant * ((object1Mass * object2Mass) / (Math.Pow(radius, 2)));
        }

        public override string ToString()
        {
            return "The gravitational force between " + Object1 + " and " + Object2 + " is " + $"{GForce:G4} m/s^2";
        }
    }
}

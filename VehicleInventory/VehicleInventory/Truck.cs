using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInventory
{
    // truck class with vehicle abstract parent class
    public class Truck : Vehicle
    {
        // constructor
        public Truck(string vin, string license) 
        {
            VIN = vin;
            LicensePlate = license;
        }

        // private field for wheels
        private int wheels = 4;

        // overriding Wheels from parent class to get private wheels variable
        public override int Wheels 
        {
            get { return wheels; }
        }
        // overriding MaxPassengers from parent class to get literal value (3) for max passengers
        public override int MaxPassengers
        {
            get { return 3; }
        }
        // overriding ToString to be custom for truck class, then the same for GetDescrition (which was abstract in parent)
        public override string ToString()
        {
            return "Truck License Plate: " + LicensePlate + " VIN: " + VIN;
        }
        public override string GetDescription()
        {
            return "Truck License Plate: " + LicensePlate + " VIN: " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers;
        }
    }
}

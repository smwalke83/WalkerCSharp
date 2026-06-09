using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInventory
{
    // sedan class with abstract parent class vehicle
    public class Sedan : Vehicle
    {
        // private field for wheels
        private int wheels = 4;
        // overriding parent Wheels field to get the wheels variable
        public override int Wheels 
        {
            get { return wheels; }
        }
        // overriding parent MaxPassengers field to get literal value (5)
        public override int MaxPassengers 
        {
            get { return 5; }
        }
        // Overrides for ToString and GetDescription (which was an abstract method in the parent)
        public override string GetDescription()
        {
            return "Sedan License Plate: " + LicensePlate + " VIN: " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers;
        }

        public override string ToString()
        {
            return "Sedan License Plate: " + LicensePlate + " VIN: " + VIN;
        }
    }
}

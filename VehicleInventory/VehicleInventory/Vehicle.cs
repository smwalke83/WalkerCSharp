using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInventory
{
    // abstract parent class for sedan and truck
    public abstract class Vehicle
    {
        // concrete members that will be inherited
        public string VIN { get; set; }
        public string LicensePlate { get; set; }
        // abstract members that will be further defined by child classes
        public abstract int Wheels { get; }
        public abstract int MaxPassengers { get; }
        public abstract string GetDescription();
    }
}

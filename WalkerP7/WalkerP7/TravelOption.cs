// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: TravelOption.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkerP7;

namespace WalkerP7
{
    // TravelOption class contains travel data about locations. This class was provided for the assignment and I only modified the comments.
    public class TravelOption
    {
        // Description of where this option goes
        public string Description { get; set; }

        // Location where this travel option goes
        public MapLocation Location { get; set; }

        // Constructor setting description and location
        public TravelOption(string description, MapLocation location)
        {
            Description = description;
            Location = location;
        }
        // ToString() Override
        public override string ToString()
        {
            return Description;
        }
    }
}

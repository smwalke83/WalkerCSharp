// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: MapLocation.cs

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkerP7
{
    // The MapLocation class will represent a single location on the map. This class was provided for the assignment and has only been modified by me.
    public class MapLocation
    {
        // Contains a description of the location
        public string Description { get; set; }

        // Observable Collection (easier with WPF than list) containing travel options (locations that can be travelled to from this one)
        public ObservableCollection<TravelOption> TravelOptions { get; set; }

        // Observable Collection containing items that are in this location
        public ObservableCollection<GameObject> Items { get; set; }

        // Constructor that sets provided description and initializes lists
        public MapLocation(string description)
        {
            Description = description;
            TravelOptions = new ObservableCollection<TravelOption>();
            Items = new ObservableCollection<GameObject>();
        }
        // ToString override
        public override string ToString()
        {
            return Description;
        }
    }
}

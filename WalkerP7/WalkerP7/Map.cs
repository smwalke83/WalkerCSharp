// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Map.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace WalkerP7
{
    // Map class represents the game. This class was provided for the assignment and has only been modified by me.
    class Map
    {
        // An observable collection (for WPF compatability) of the game locations
        public ObservableCollection<MapLocation> Locations { get; set; }
        // Map constructor
        public Map()
        {
            // Initialize locations lsit
            Locations = new ObservableCollection<MapLocation>();

            // Creating map locations
            Locations.Add(new MapLocation("You are standing outside a faire."));
            Locations.Add(new MapLocation("You are in the faire, by the entrance."));
            Locations.Add(new MapLocation("You are by some horse stables."));
            Locations.Add(new MapLocation("You are near some carnival games."));
            Locations.Add(new MapLocation("You are at the ring toss game."));
            Locations.Add(new MapLocation("You are at the shooting game."));

            // Adding Travel Options to each location (areas that each location is connected to), then adding portables, hiding places, and portable hiding places to each location

            // The first location is outside the faire with one travel option: enter the faire
            Locations[0].TravelOptions.Add(new TravelOption("Enter the faire.", Locations[1]));
            // There is a pebble (portable) that can be picked up in this location.
            Locations[0].Items.Add(new InventoryItem(1, "Pebble"));

            // The second location is at the entrance of the faire. You can go back, left, or right.
            Locations[1].TravelOptions.Add(new TravelOption("Go back outside.", Locations[0]));
            Locations[1].TravelOptions.Add(new TravelOption("Head left, toward the stables.", Locations[2]));
            Locations[1].TravelOptions.Add(new TravelOption("Head right, toward the carnival games.", Locations[3]));
            // There is a false rock (hiding place, not portable) that contains a carnival ticket (portable) in this location.
            HidingPlace falseRock = new HidingPlace("False Rock");
            falseRock.HiddenObject = new InventoryItem(1, "Carnival Ticket");
            Locations[1].Items.Add(falseRock);

            // The third location is at the horse stables (left from entrance). You can only go back from here.
            Locations[2].TravelOptions.Add(new TravelOption("Go back to the entrance.", Locations[1]));
            // There is a satchel (portable hiding place) that contains a horse figurine (portable) if searched. It can be taken whether or not it is searched.
            PortableHidingPlace satchel = new PortableHidingPlace(new InventoryItem(1, "Horse Figurine"), 1, "Small Satchel");
            Locations[2].Items.Add(satchel);

            // The fourth location is at the carnival games (right from entrance). You can go back, left or right.
            Locations[3].TravelOptions.Add(new TravelOption("Go back to the entrance.", Locations[1]));
            Locations[3].TravelOptions.Add(new TravelOption("Head left, toward the ring toss game.", Locations[4]));
            Locations[3].TravelOptions.Add(new TravelOption("Head right, toward the shooting game.", Locations[5]));
            // There is a deck of cards (portable) that can be picked up in this locaton.
            Locations[3].Items.Add(new InventoryItem(1, "Deck of Cards"));

            // The fifth location is a ring toss game. You can only go back from here.
            Locations[4].TravelOptions.Add(new TravelOption("Go back to the carnival game entrance.", Locations[3]));
            // There is a loose stone (hiding place, not portable) that contains a keepsake (portable) in this locaiton.
            HidingPlace looseStone = new HidingPlace("Loose Stone");
            looseStone.HiddenObject = new InventoryItem(1, "Keepsake");
            Locations[4].Items.Add(looseStone);

            // The sixth and final location is a shooting game. You can only go back from here.
            Locations[5].TravelOptions.Add(new TravelOption("Go back to the carnival game entrance.", Locations[3]));
            // There is a bag (portable hiding place) that contains a stained shirt (portable) if searched. It can be taken whether or not it is searched.
            PortableHidingPlace bag = new PortableHidingPlace(new InventoryItem(1, "Stained Shirt"), 1, "Small Bag");
            Locations[5].Items.Add(bag);
        }
    }
}

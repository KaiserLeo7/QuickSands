using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class LocationDB {

        private static List<Location> locations = new List<Location>();

        void Awake() {
            BuildClassDatabase();
        }

        void BuildClassDatabase() 
        {
            locations = new List<Location>() {
                //string locationName, double latitude, double longitude
                new Location(1, "Norwich", 100, 100, 1, int[] nearbyTowns{2}),
                new Location(2, "Westray", 100,100,1),
                new Location(3, "Gillamoor", 100,100,2),
                new Location(4, "Tunstead", 100,100,2),
                new Location(5, "Veden", 100,100,1),
                new Location(6, "Fara", 100,100,2),
                new Location(7, "Kaiser", 100,100,3),
                new Location(8, "Braedon", 100,100,3),
                new Location(9, "Helm Crest", 100,100,3),
                new Location(10, "Dalhurst", 100,100,3)

            };
        }
    

        //get database
        public List<Location> getLocationList() {
            return locations;
        }

        //get Armor at position
        public Location getLocation(int position) {
            return locations[position];
        }

        //clear
        public void clearLocationList() {
            locations.Clear();
        }

    }
}

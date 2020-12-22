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
                new Location("Norwich", 100,100),
                new Location("Westray", 100,100),
                new Location("Gillamoor", 100,100),
                new Location("Tunstead", 100,100),
                new Location("Veden", 100,100),
                new Location("Fara", 100,100),
                new Location("Kaiser", 100,100),
                new Location("Braedon", 100,100),
                new Location("Helm Crest", 100,100),
                new Location("Dalhurst", 100,100)

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

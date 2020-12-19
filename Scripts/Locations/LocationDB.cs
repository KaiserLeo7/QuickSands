using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class LocationDB {

        private List<Location> locations = new List<Location>();

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

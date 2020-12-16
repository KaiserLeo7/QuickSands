using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        //delete
        public List<Location> deleteLocation(Location location) {
            return locations = locations.Except(locations.Where(l => l.locationName == location.locationName)).ToList();
        }

        //clear
        public void clearLocationList() {
            locations.Clear();
        }

    }
}

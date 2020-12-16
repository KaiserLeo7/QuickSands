using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{

    public class Location {
    private string locationName;
    private double latitude;
    private double longitude;

        public Location(string locationName, double latitude, double longitude) {
            this.locationName = locationName;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public string LocationName {
            get
            {
                return locationName;
            }
            set
            {
                locationName = value;
            }
        }

        public double Latitude
        {
            get 
            {
                return latitude;
            }
            set
            {
                latitude = value;
            }
        }

        public double Longitude {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
            }
        }
    }
}
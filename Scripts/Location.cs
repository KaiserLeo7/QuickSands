using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{

    public class Location {
    private string name;
    private double latitude;
    private double longitude;

        public Location(string name, double latitude, double longitude) {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
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
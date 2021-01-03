using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{

    public class Location {

    private int id;
    private string locationName;
    private double latitude;
    private double longitude;
    private int[] nearbyTowns;
    private int territory;

    public Location(int id, string locationName, double latitude, double longitude, int territory, int[] nearbyTowns) {
        this.id = id;
        this.locationName = locationName;
        this.latitude = latitude;
        this.longitude = longitude;
        this.territory = territory;
        this.nearbyTowns = nearbyTowns;
    }

        public int Id {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
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

        public int Territory
        {
            get 
            {
                return territory;
            }
            set
            {
                territory = value;
            }
        }

        public int[] NearbyTowns
        {
            get 
            {
                return nearbyTowns;
            }
            set
            {
                nearbyTowns = value;
            }
        }
    }
}
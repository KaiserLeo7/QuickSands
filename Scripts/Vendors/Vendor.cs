using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands

{

    public class Vendor
    {
        private string name;
        private Location location { get; }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Vendor(string name, string locationName, double latt, double longtitude)
        {
            this.name = name;
            location = new Location(locationName, latt, longtitude);
        }

    }
}
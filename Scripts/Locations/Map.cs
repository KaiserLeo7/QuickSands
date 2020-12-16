using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{

    public class Map 
    {

    private double height;
    private double width;
   
    private Location location{get;}

        public Map(double height, double width, string locationName, double latitude, double longitude) {
            this.height = height;
            this.width = width;
            location = new Location(locationName, latitude, longitude);
        }

        public double Height 
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
    }

}
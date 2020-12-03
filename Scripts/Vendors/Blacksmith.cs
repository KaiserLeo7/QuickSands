using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : Vendor
{
    //need something to specify only certain types of items can be sold here

    public Blacksmith(string name, string locationName, double lattitude, double longtitude) : base(name, locationName, lattitude, longtitude){}
}
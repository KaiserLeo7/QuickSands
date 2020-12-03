using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vendor 
{
    private string name;
    private Location location{get;}

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

    public Vendor(string name, string locationName, double latt, double long)
    {
        location = new Location(locationName, latt, long);
    }

}
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

public Map (double height, double width, string name, double lattitude, double longtitude) 
{
    this.height = height;
    this.width = width;
    location = new Location(name, lattitude, longtitude);
}

}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location 

{
private string name;
private double lattitude;
private double longtitude;


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

public double Lattitude
{
    get 
    {
        return lattitude;
    }

    set
    {
        lattitude = value;
    }
}

public double Longtitude
{
    get
    {
        return longtitude;
    }
    set
    {
        longtitude = value;
    }
}

public Location (string name, double lattitude, double longtitude)
{
    this.name = name;
    this.lattitude = lattitude;
    this.longtitude = longtitude;
}

}
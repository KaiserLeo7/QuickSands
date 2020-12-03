using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle
{
    private string name;
    private int health;
    private int armour;
    private double speed;
    private int buttSpace;
    private int damage;
    private double weight;

    public Name
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
    public Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public Armour
    {
        get
        {
            return armour;
        }

        set
        {
            armour = value;
        }
    }

    public Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public ButtSpace
    {
        get
        {
            return buttSpace;
        }

        set
        {
            buttSpace = value;
        }
    }

    public Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    public Weight
    {
        get
        {
            return weight;
        }

        set
        {
            weight = value;
        }
    }

    public Vehicle(string name, int health, int armour, double speed, int buttspace, int damage, double weight){};

}
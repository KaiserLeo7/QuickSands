using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipable : Item
{
    private HeroClass heroClass{get;}
    //recipe

    public Equipable(string itemName, double weight, double price, int hero) : base(itemName, weight, price)
    {
        heroClass = new HeroClass(hero);
    }
}

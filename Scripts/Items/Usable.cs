using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tradeable : Item
{
    private int effectAmount{get; set;}
    public Tradeable(int effectAmount,string itemName, double weight, double price) : base(itemName, weight, price)
    {
        this.effectAmount = effectAmount;
    }
}
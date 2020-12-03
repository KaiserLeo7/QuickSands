using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipable
{

    private int damage{get; set;}
    private double crit{get; set;}

    public Weapon(int damage, double crit, string itemName, double weight, double price, int hero) : base(itemName, weight, price, hero)
    {
        this.damage = damage;
        this.crit = crit;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

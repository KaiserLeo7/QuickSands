using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : MonoBehaviour
{
    private int health;
    private double defence;

    public Armor(int health, double defence, string itemName, double weight, double price, int hero) : base(itemName, weight, price, hero)
    {
        this.health = health;
        this.defence = defence;
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

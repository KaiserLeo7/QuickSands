using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Item[] itemSet;

    public Inventory(){}
    
    public Inventory(Item[] itemSet)
    {
        this.itemSet = itemSet;
    }
}

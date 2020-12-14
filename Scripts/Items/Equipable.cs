using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Equipable : Item
    {
        private bool equipped { get; set; }

        public Equipable(string itemName, double weight, double price, int hero) : base(itemName, weight, price)
        {
            
        }
    }

}

using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Inventory : MonoBehaviour
    {
        private List<Item> itemSet;

        public Inventory() { }

        public Inventory(List<Item> itemSet)
        {
            this.itemSet = itemSet;
        }
    }
}


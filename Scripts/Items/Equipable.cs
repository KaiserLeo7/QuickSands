using UnityEngine;

namespace Sands
{
    public class Equipable : Item
    {
        private bool equipped { get; set; }

        public Equipable(int ID, string itemName, double weight, double price, int hero) : base(ID, itemName, weight, price)
        {

        }
    }
}

using UnityEngine;

namespace Sands
{
    public class Usable : Item
    {
        private int effectAmount { get; set; }
        public Usable(string itemName, double weight, double price, int effectAmount) : base(itemName, weight, price)
        {
            this.effectAmount = effectAmount;
        }
    }
}
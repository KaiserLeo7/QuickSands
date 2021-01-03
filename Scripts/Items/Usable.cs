using UnityEngine;

namespace Sands
{
    public class Usable : Item
    {
        private int effectAmount { get; set; }
        public Usable(int ID, string itemName, double weight, double price, int effectAmount) : base(ID, itemName, weight, price)
        {
            this.effectAmount = effectAmount;
        }
    }
}
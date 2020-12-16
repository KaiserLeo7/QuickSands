using UnityEngine;

namespace Sands
{
    public class Armor : Equipable
    {
        private int health;
        private double defence;

        public Armor(int health, double defence, string itemName, double weight, double price, int hero) : base(itemName, weight, price, hero)
        {
            this.health = health;
            this.defence = defence;
        }
    }
}

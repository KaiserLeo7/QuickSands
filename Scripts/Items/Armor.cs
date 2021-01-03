using UnityEngine;

namespace Sands
{
    public class Armor : Equipable
    {
        private int health;
        private double defence;

        public Armor(int ID, int health, double defence, string itemName, double weight, double price, int hero) : base(ID, itemName, weight, price, hero)
        {
            this.health = health;
            this.defence = defence;
        }
    }
}

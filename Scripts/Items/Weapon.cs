using UnityEngine;

namespace Sands
{
    public class Weapon : Equipable
    {
        private int damage { get; set; }
        private int crit { get; set; }

        public Weapon(int damage, int crit, string itemName, double weight, double price, int hero) : base(itemName, weight, price, hero)
        {
            this.damage = damage;
            this.crit = crit;
        }
    }
}
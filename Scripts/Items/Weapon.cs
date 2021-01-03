using UnityEngine;

namespace Sands
{
    public class Weapon : Equipable
    {
        private int damage { get; set; }
        private int crit { get; set; }

        public Weapon(int ID, int damage, int crit, string itemName, int weight, double price, int hero) : base(ID, itemName, weight, price, hero)
        {
            this.damage = damage;
            this.crit = crit;
        }
    }
}
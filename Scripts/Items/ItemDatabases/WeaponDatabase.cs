using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands
{
    public class WeaponDatabase
    {

        private static List<Weapon> weapons = new List<Weapon>();

        //get database
        public List<Weapon> getWeaponList()
        {
            return weapons;
        }

        void BuildClassDatabase()
        {
            weapons = new List<Weapon>() {
                //int damage, double crit, string itemName, double weight, double price, int hero
                new Weapon(10, 10, "Iron Sword", 10, 20.0, 0),
                new Weapon(20, 10, "Steel Sword", 10, 40.0, 0),
                new Weapon(30, 10, "Damascus Steel Sword", 10, 80.0, 0),
                new Weapon(40, 10, "Sky Steel Sword", 10, 160.0, 0),
                new Weapon(80, 20, "Ashen Remeberance", 25, 500.0, 0),
                new Weapon(5, 20, "Hunting Bow", 5, 20.0, 1),
                new Weapon(10, 20, "Longbow", 5, 40.0, 1),
                new Weapon(15, 20, "CrossBow", 5, 80.0, 1),
                new Weapon(20, 20, "Compound Bow", 5, 160.0, 1),
                new Weapon(50, 33, "Desert's Call", 10, 500.0, 1),
                new Weapon(15, 1, "Mage's Orb", 1, 10.0, 2),
                new Weapon(10, 5, "Elm Wand", 1, 20.0, 2),
                new Weapon(20, 15, "Elm Staff", 5, 40.0, 2),
                new Weapon(15, 5, "Oak Wand", 1, 80.0, 2),
                new Weapon(25, 15, "Obsidian Staff", 5, 160.0, 2),
                new Weapon(60, 25, "Magnum Opus", 10, 500.0, 2)
            };
        }

        //get Hero at position
        public Weapon getWeapon(int position)
        {
            return weapons[position];
        }

        //delete
        public List<Weapon> deleteWeapon(Weapon weapon)
        {
            return weapons = weapons.Except(weapons.Where(a => a.ItemName == weapon.ItemName)).ToList();
        }

        //clear
        public void clearWeaponList()
        {
            weapons.Clear();
        }
    }
}
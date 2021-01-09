using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public static class WeaponDatabase
    {

        private static List<Weapon> weapons = new List<Weapon>();

        //get database
        public static List<Weapon> getWeaponList()
        {
            return weapons;
        }

        static WeaponDatabase()
        {
            weapons = new List<Weapon>() {
                //int ID, int damage, double crit, string itemName, double weight, double price, int hero
                new Weapon(1, 10, 10, "Iron Sword", 10, 20.0, 0),
                new Weapon(2, 20, 10, "Steel Sword", 10, 40.0, 0),
                new Weapon(3, 30, 10, "Damascus Steel Sword", 10, 80.0, 0),
                new Weapon(4, 40, 10, "Sky Steel Sword", 10, 160.0, 0),
                new Weapon(5, 80, 20, "Ashen Remeberance", 25, 500.0, 0),
                new Weapon(6, 5, 20, "Hunting Bow", 5, 20.0, 1),
                new Weapon(7, 10, 20, "Longbow", 5, 40.0, 1),
                new Weapon(8, 15, 20, "CrossBow", 5, 80.0, 1),
                new Weapon(9, 20, 20, "Compound Bow", 5, 160.0, 1),
                new Weapon(10, 50, 33, "Desert's Call", 10, 500.0, 1),
                new Weapon(11, 15, 1, "Mage's Orb", 1, 10.0, 2),
                new Weapon(12, 10, 5, "Elm Wand", 1, 20.0, 2),
                new Weapon(13, 20, 15, "Elm Staff", 5, 40.0, 2),
                new Weapon(14, 15, 5, "Oak Wand", 1, 80.0, 2),
                new Weapon(15, 25, 15, "Obsidian Staff", 5, 160.0, 2),
                new Weapon(16, 60, 25, "Magnum Opus", 10, 500.0, 2)
            };
        }

        //get Hero at position
        public static Weapon getWeapon(int position)
        {
            return weapons[position];
        }
   
    }
}
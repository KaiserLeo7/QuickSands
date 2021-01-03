using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands
{
    public class ItemDatabase
    {

        private List<Item> items = new List<Item>();

        //get database
        public List<Item> getItemList()
        {
            return items;
        }

        void BuildClassDatabase()
        {
            items = new List<Item>() {
                //int health, double defence, string itemName, double weight, double price, int hero
                new Armor(10, 10, "Chainmail Vest", 15, 30.0, 0),
                new Armor(20, 15, "Iron Gamberson", 20, 50.0, 0),
                new Armor(30, 20, "Steel Gamberson", 25, 70.0, 0),
                new Armor(40, 25, "Full Plate Armour", 40, 200.0, 0),
                new Armor(80, 33, "Mobile Fortress", 50, 500.0, 0),
                new Armor(5, 1, "Leather Armour", 10, 20.0, 1),
                new Armor(10, 5, "Hardened Leather Armour", 10, 40.0, 1),
                new Armor(20, 10, "Leather Cuirass", 10, 50.0, 1),
                new Armor(30, 15, "Chitin Armour", 15, 80.0, 1),
                new Armor(40, 20, "Vestments of the Unseen", 20, 500.0, 1),
                new Armor(1, 1, "Torn Doublet", 1, 10.0, 2),
                new Armor(5, 1, "Hermit's Old Robes", 1, 20.0, 2),
                new Armor(10, 1, "Cloth Robes", 1, 50.0, 2),
                new Armor(15, 5, "Voluminous Robes", 5, 80.0, 2),
                new Armor(20, 10, "Drapes of the Profligate Seer", 10, 500.0, 2),

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
                new Weapon(60, 25, "Magnum Opus", 10, 500.0, 2),

                //string itemName, double weight, double price
                new Tradeable("Cloth", 2, 30.0),
                new Tradeable("Leather", 3, 35.0),
                new Tradeable("Spices", 1, 25.0),
                new Tradeable("Rations", 2, 20.0),
                new Tradeable("Coal", 5, 40.0),
                new Tradeable("Steel", 7, 55.0),
                new Tradeable("Tools", 5, 45.0),
                new Tradeable("Silver", 6, 65.0),
                new Tradeable("Gold", 6, 70.0),
                new Tradeable("Diamonds", 5, 100.0),

                //string itemName, double weight, double price, int effectAmount
                new Usable("Health Potion", 2, 100.0, 100),
                new Usable("Repair Kit", 2, 200.0, 500)
            };
        }
        //get Armor at position
        public Item getItem(int position)
        {
            return items[position];
        }

        public Item getItem(string itemName)
        {
            return items.Single(i => i.ItemName == itemName);
        }

        //clear
        public void clearItemList()
        {
            items.Clear();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands
{
    public class ArmorDatabase
    {

        private static List<Item> items = new List<Item>();

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

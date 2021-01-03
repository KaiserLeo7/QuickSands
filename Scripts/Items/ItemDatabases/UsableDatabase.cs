using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class UsableDatabase
    {

        private static List<Usable> usables = new List<Usable>();

        //get database
        public List<Usable> getUsableList()
        {
            return usables;
        }

        void BuildClassDatabase()
        {
            usables = new List<Usable>() {
                //string itemName, double weight, double price, int effectAmount
                new Usable("Health Potion", 2, 100.0, 100),
                new Usable("Repair Kit", 2, 200.0, 500)
            };
        }

        //get Hero at position
        public Usable getUsable(int position)
        {
            return usables[position];
        }
    }
}
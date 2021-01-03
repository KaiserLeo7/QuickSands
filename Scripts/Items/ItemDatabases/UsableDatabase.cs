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
                //int ID, string itemName, int weight, double price, int effectAmount
                new Usable(1, "Health Potion", 2, 100.0, 100),
                new Usable(2, "Repair Kit", 2, 200.0, 500)
                
            };
        }

        //get Hero at position
        public Usable getUsable(int position)
        {
            return usables[position];
        }
    }
}
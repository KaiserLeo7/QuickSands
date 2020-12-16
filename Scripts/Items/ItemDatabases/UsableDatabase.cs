using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands
{
    public class UsableDatabase
    {

        private List<Usable> usables = new List<Usable>();

        //get database
        public List<Usable> getUsableList()
        {
            return usables;
        }

        void BuildClassDatabase()
        {
            usables = new List<Usable>() {
                //(itemName, weight, price, effectAmount)
                new Usable("Health Potion", 2, 100.0, 100),
                new Usable("Repair Kit", 2, 200.0, 500)
            };
        }

        //get Hero at position
        public Usable getUsable(int position)
        {
            return usables[position];
        }

        //delete
        public List<Usable> deleteUsable(Usable usable)
        {
            return usables = usables.Except(usables.Where(u => u.ItemName == usable.ItemName)).ToList();
        }

        //clear
        public void clearUsableList()
        {
            usables.Clear();
        }
    }
}
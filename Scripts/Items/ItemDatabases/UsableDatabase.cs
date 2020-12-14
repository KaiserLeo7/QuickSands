using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class UsableDatabase {

        private List<Usable> usables = new List<Usable>();

        //get database
        public List<Usable> getUsableList() {
            return usables;
        }

        //get Hero at position
        public Usable getUsable(int position) {
            return usables[position];
        }

        //delete
        public List<Usable> deleteUsable(Usable usable) {
            return usables = usables.Except(usables.Where(u => u.ItemName == usable.ItemName)).ToList();
        }

        //clear
        public void clearUsableList() {
            usables.Clear();
        }

    }
}
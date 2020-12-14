using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class ArmorDatabase {

        private List<Armor> armors = new List<Armor>();

        //get database
        public List<Armor> getArmorList() {
            return armors;
        }

        //get Hero at position
        public Armor getArmor(int position) {
            return armors[position];
        }

        //delete
        public List<Armor> deleteArmor(Armor armor) {
            return armors = armors.Except(armors.Where(a => a.ItemName == armor.ItemName)).ToList();
        }

        //clear
        public void clearEnemyList() {
            armors.Clear();
        }

    }
}

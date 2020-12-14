using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class WeaponDatabase {

        private List<Weapon> weapons = new List<Weapon>();

        //get database
        public List<Weapon> getWeaponList() {
            return weapons;
        }

        //get Hero at position
        public Weapon getWeapon(int position) {
            return weapons[position];
        }

        //delete
        public List<Weapon> deleteWeapon(Weapon weapon) {
            return weapons = weapons.Except(weapons.Where(a => a.ItemName == weapon.ItemName)).ToList();
        }

        //clear
        public void clearWeaponList() {
            weapons.Clear();
        }

    }
}
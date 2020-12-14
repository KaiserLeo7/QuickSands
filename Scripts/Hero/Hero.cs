using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation
namespace Sands {
    public class Hero {
        //unit values
        public string unitName;
        public int unitLevel;

        public int damage;

        public int maxHP;
        public int currentHP;
        
      
        public Hero(string unitName, int unitLevel, int damage, int maxHP, int currentHP) {
            this.unitName = unitName;
            this.unitLevel = unitLevel;
            this.damage = damage;
            this.maxHP = mapHP;
            this.currentHP = currentHP;
        }

        public bool TakeDamage(int dmg) {
            currentHP -= dmg;

            if (currentHP <= 0) {
                currentHP = 0;
                return true;
            } else {
                return false;
            }
        }

        public void Heal(int healAmount) {
            currentHP += healAmount;
            if (currentHP > maxHP)
                currentHP = maxHP;
        }

       
        /////////// GETTERS AND SETTERS //////////
        

        public string UnitName {
            get {
                return unitName;
            }
            set {
                unitName = value;
            }
        }

        public string UnitLevel {
            get {
                return unitLevel;
            }
            set {
                unitLevel = value;
            }
        }

        public string Damage {
            get {
                return damage;
            }
            set {
                damage = value;
            }
        }

        public string MapHP {
            get {
                return mapHP;
            }
            set {
                mapHP = value;
            }
        }

        public string CurrentHP {
            get {
                return currentHP;
            }
            set {
                currentHP = value;
            }
        }
        
    }
}
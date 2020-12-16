using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation
namespace Sands {
    public class Hero {
        //unit values
        private int heroID;
        private int heroLevel;
        private string heroClass;

        private int damage;
        private double critDamage;

        private int maxHP;
        private int currentHP;
        
      
        public Hero(int heroID, string heroClass, int heroLevel, int damage, double critDamage, int maxHP, int currentHP) {
            this.heroID = heroID;
            this.heroLevel = heroLevel;
            this.heroClass = heroClass;
            this.damage = damage;
            this.critDamage = critDamage;
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
        

        public string HeroID {
            get {
                return heroID;
            }
            set {
                heroID = value;
            }
        }

        public string HeroLevel {
            get {
                return heroLevel;
            }
            set {
                heroLevel = value;
            }
        }

        public string HeroClass {
            get {
                return heroClass;
            }
            set {
                heroClass = value;
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

        public string CritDamage {
            get {
                return critDamage;
            }
            set {
                critDamage = value;
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
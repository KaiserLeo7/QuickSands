using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation
namespace Sands {
    public class Hero {
        //unit values
        
        private int damage;
        private double critDamage;

        private int maxHP;
        private int currentHP;
        
      
        public Hero( int damage, double critDamage, int maxHP, int currentHP) {
    
            this.damage = damage;
            this.critDamage = critDamage;
            this.maxHP = maxHP;
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
        

        public int Damage {
            get {
                return damage;
            }
            set {
                damage = value;
            }
        }

        public double CritDamage {
            get {
                return critDamage;
            }
            set {
                critDamage = value;
            }
        }

        public int MaxHP {
            get {
                return maxHP;
            }
            set {
                maxHP = value;
            }
        }

        public int CurrentHP {
            get {
                return currentHP;
            }
            set {
                currentHP = value;
            }
        }
        
    }
}
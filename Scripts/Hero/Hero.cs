using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation
namespace Sands {
    public abstract class Hero {
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

        public abstract bool TakeDamage(int dmg);

        public abstract void Heal(int healAmount);

       
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
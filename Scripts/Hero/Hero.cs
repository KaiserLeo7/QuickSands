using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation
namespace Sands {
    public abstract class Hero {
        //unit values
        
        private int damage;
        private double critChance;

        private int maxHP;
        private int currentHP;
        
        private int capacity;
        
      
        public Hero( int damage, double critChance, int maxHP, int currentHP, int capacity) {
    
            this.damage = damage;
            this.critChance = critChance;
            this.maxHP = maxHP;
            this.currentHP = currentHP;
            this.capacity = capacity;
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

        public double CritChance {
            get {
                return critChance;
            }
            set {
                critChance = value;
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

        public int Capacity {
            get {
                return capacity;
            }
            set {
                capacity = value;
            }
        }
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Enemy
    {
        private int damage;
        private double critChance;
        private int maxHealth;
        private int currentHealth;

        public Enemy(int damage, double critChance, int maxHealth, int currentHealth) {
           
            this.damage = damage;
            this.critChance = critChance;
            this.maxHealth = maxHealth;
            this.currentHealth = currentHealth;
        }

        /////////// GETTERS AND SETTERS //////////

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }

        public double CritDamage
            {
                get
                {
                    return critChance;
                }
                set
                {
                    critChance = value;
                }
        }


        public int MaxHealth
        {
            get
            {
                return maxHealth;
            }
            set
            {
                maxHealth = value;
            }
        }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                currentHealth = value;
            }
        }
        
    }
}
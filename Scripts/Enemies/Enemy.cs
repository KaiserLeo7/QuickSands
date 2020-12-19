using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Enemy
    {
        private int damage;
        private double critDamage;
        private int maxHealth;
        private int currentHealth;

        public Enemy(int damage, double critDamage, int maxHealth, int currentHealth) {
           
            this.damage = damage;
            this.critDamage = critDamage;
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
                    return critDamage;
                }
                set
                {
                    critDamage = value;
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
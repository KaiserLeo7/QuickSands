using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Enemy
    {
        private int enemyDamage;
        private double enemyCritDamage;

        private int enemyMaxHealth;
        private int enemyCurrentHealth;

        public Enemy(int enemyDamage, double enemyCritDamage, int enemyMaxHealth, int enemyCurrentHealth) {
           
            this.enemyDamage = enemyDamage;
            this.enemyCritDamage = enemyCritDamage;
            this.enemyMaxHealth = enemyMaxHealth;
            this.enemyCurrentHealth = enemyCurrentHealth;
        }

        /////////// GETTERS AND SETTERS //////////

        public int EnemyDamage
        {
            get
            {
                return enemyDamage;
            }
            set
            {
                enemyDamage = value;
            }
        }

        public int EnemyDamage
            {
                get
                {
                    return enemyDamage;
                }
                set
                {
                    enemyDamage = value;
                }
        }


        public int EnemyHealth
        {
            get
            {
                return enemyHealth;
            }
            set
            {
                enemyHealth = value;
            }
        }

        public int EnemyDamage
        {
            get
            {
                return enemyDamage;
            }
            set
            {
                enemyDamage = value;
            }
        }
        
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Enemy
    {
        private string enemyName;
        private string enemyType;
        private int enemyHealth;
        private int enemyDamage;

        public Enemy(string enemyName, string enemyType, int enemyHealth, int enemyDamage) {
            this.enemyName = enemyName;
            this.enemyType = enemyType;
            this.enemyHealth = enemyHealth;
            this.enemyDamage = enemyDamage;
        }

       
        /////////// GETTERS AND SETTERS //////////

        public string EnemyName {
            get {
                return enemyName;
            }
            set {
                enemyName = value;
            }
        }

        public string EnemyType {
            get {
                return enemyType;
            }
            set {
                enemyType = value;
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
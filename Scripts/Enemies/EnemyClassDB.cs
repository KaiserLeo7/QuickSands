using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class EnemyClassDB {

        private static List<Enemy> enemies = new List<Enemy>();


    void Awake() {
        BuildClassDatabase();
    }

    void BuildClassDatabase() 
    {
        enemies = new List<Enemy>() {
           //int damage, double critDamage, int maxHealth, int currentHealth
        new EnemyGround(),
        new EnemyFlying(),
        new EnemyBoss()
        };
    }
    
        //get database
        public List<Enemy> getEnemyList() {
            return enemies;
        }

        //get Hero at position
        public Enemy getEnemy(int position) {
            return enemies[position];
        }        

        //clear
        public void clearEnemyList() {
            enemies.Clear();
        }

    }
}


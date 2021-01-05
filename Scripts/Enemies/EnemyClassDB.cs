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
           //int damage, int critChance, int maxHealth, int currentHealth
        new EnemyGround(350, 20, 300, 300),
        new EnemyFlying(400, 15, 100, 100),
        new EnemyBoss(500, 35, 3000, 3000)
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


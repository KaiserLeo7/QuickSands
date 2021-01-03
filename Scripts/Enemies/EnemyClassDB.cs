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
        new EnemyGround(200, 20, 30, 30),
        new EnemyFlying(350, 15, 10, 10),
        new EnemyBoss(500, 35, 500, 500)
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


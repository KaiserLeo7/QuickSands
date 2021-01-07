using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Sands {
    public class EnemyClassDB {

        private static List<Enemy> enemies = new List<Enemy>();


    void Start() {
        BuildClassDatabase();
    }

    void BuildClassDatabase() 
    {
        enemies = new List<Enemy>() {
           //int id, int damage, int critChance, int maxHealth, int currentHealth
        new EnemyGround(1,200, 10, 750, 750),
        new EnemyFlying(2,300, 25, 400, 400),
        new EnemyBoss(3,750, 20, 5000, 5000)
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


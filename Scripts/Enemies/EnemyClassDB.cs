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
           
        new EnemyGround(),
        new EnemyFlying(),
        new EnemyBoss();
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

        //delete
        public List<Enemy> deleteEnemy(Enemy enemy) {
            return enemies = enemies.Except(enemies.Where(e => e.EnemyName == enemy.EnemyName)).ToList();
        }

        //clear
        public void clearEnemyList() {
            enemies.Clear();
        }

    }
}


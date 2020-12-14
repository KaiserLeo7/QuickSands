using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class EnemyDatabase {

        private static List<Enemy> enemies = new List<Enemy>();

        //get database
        public List<Enemy> getEnemyList() {
            return enemies;
        }

        //get Hero at position
        public Enemy getEnemy(int position) {
            return enemies[position];
        }


        //insert
        public List<Enemy> insertEnemy(Enemy enemy) {
            if (enemyName != null)
                enemies.Add(enemy);

            return enemies;
        }

        //delete
        public List<Enemy> deleteEnemy(Enemy enemy) {
            for (int i = 0; i < enemies.lenght; i++) {

                if (enemies[i].enemyName == enemy.enemyName)
                    enemies.RemoveAt(i);
            }
            return enemies;
        }

        //clear
        public void clearEnemyList() {
            enemies.RemoveAll();
        }

    }
}


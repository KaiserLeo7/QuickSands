using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Nest : Location
    {
        private EnemyClassDB enemyClassDB = new EnemyClassDB();
        private List<Enemy> enemies;
        private List<Enemy> wave1;
        private List<Enemy> wave2;
        private List<Enemy> wave3;
        private int multiplier;

        public Nest(int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns, int multiplier) : base(id, name, lattitude, longtitude, territory, nearbyTowns)
        {
            enemies = new List<Enemy>(){
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(1),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(1),
                enemyClassDB.getEnemy(1),
                enemyClassDB.getEnemy(2)
            };
            
            foreach (Enemy enemy in enemies)
            {
                enemy.Damage *= multiplier;
                enemy.MaxHealth *= multiplier;
                enemy.CurrentHealth *= multiplier;
            }

            wave1 = new List<Enemy>(){
                enemies[0],
                enemies[1],
                enemies[2]
            };
            wave2 = new List<Enemy>(){
                enemies[3],
                enemies[4],
                enemies[5],
                enemies[6],
                enemies[7]
            };
             wave3 = new List<Enemy>(){
                enemies[8]
            };
        }
    }
}
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
        protected int multiplier;

        public Nest(int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns, int multiplier) : base(id, name, lattitude, longtitude, territory, nearbyTowns)
        {
            enemies = enemyClassDB.getEnemyList();
            
            foreach (Enemy enemy in enemies)
            {
                enemy.Damage *= multiplier;
                enemy.MaxHealth *= multiplier;
                enemy.CurrentHealth *= multiplier;
            }

            wave1 = new List<Enemy>(){
                enemies[0],
                enemies[0],
                enemies[1]
            };
            wave2 = new List<Enemy>(){
                enemies[0],
                enemies[0],
                enemies[0],
                enemies[1],
                enemies[1]
            };
             wave3 = new List<Enemy>(){
                enemies[2]
            };
        }

        public int Multiplier
        {
            get{ return multiplier; }
            set{ multiplier = value; }
        }
    }
}
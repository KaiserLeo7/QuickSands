using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Nest : Location
    {
        private EnemyClassDB enemyClassDB = new EnemyClassDB();
        private List<Enemy> wave1;
        private List<Enemy> wave2;
        private List<Enemy> wave3;

        public Nest(int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns) : base(id, name, lattitude, longtitude, territory, nearbyTowns)
        {
            wave1 = new List<Enemy>(){
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(1)
            };
            wave2 = new List<Enemy>(){
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(0),
                enemyClassDB.getEnemy(1),
                enemyClassDB.getEnemy(1)
            };
             wave3 = new List<Enemy>(){
                enemyClassDB.getEnemy(2)
            };
        }
    }
}
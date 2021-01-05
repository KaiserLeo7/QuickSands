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
        private int multiplier;

        public Nest(int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns, int multiplier) : base(id, name, lattitude, longtitude, territory, nearbyTowns)
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
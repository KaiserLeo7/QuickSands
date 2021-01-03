using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Nest : Location
    {
        private List<Enemy> enemySet{get;}


        public Nest(int id, string name, double lattitude, double longtitude, int territory, int[] nearbyTowns) : base(id, name, lattitude, longtitude, territory, nearbyTowns)
        {
            enemySet = new List<Enemy>();
        }



    }

}





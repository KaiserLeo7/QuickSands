using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class Nest : Location
    {
        private List<Enemy> enemySet{get;}


        public Nest(string name, double lattitude, double longtitude, int territory) : base(name, lattitude, longtitude, territory)
        {
            enemySet = new List<Enemy>();
        }



    }

}





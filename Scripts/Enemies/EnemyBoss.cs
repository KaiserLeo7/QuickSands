using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class EnemyBoss : Enemy
    {


        public EnemyBoss(string enemyName, string enemyType, int health, int damage) : base(enemyName, enemyType, health, damage) { }

        //what distinguishes bosses? Maybe an ability?
        /*public ability()
        {

        }*/

    }
}
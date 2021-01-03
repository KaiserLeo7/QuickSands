using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class EnemyBoss : Enemy
    {


        public EnemyBoss(int damage, int critChance, int maxHealth, int currentHealth) : base(damage, critChance, maxHealth, currentHealth) { }

        //what distinguishes bosses? Maybe an ability?
        /*public ability()
        {

        }*/

    }
}
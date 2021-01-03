using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class EnemyGround : Enemy
    {
        public EnemyGround(int damage, double critChance, int maxHealth, int currentHealth) : base(damage, critChance, maxHealth, currentHealth) { }

    }
}
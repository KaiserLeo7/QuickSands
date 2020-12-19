using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class EnemyGround : Enemy
    {
        public EnemyGround(int damage, double critDamage, int maxHealth, int currentHealth) : base(damage, critDamage, maxHealth, currentHealth) { }

    }
}
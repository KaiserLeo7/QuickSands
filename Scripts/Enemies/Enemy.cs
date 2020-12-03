using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sands

{
public class Enemy
{
private int enemyHealth;
private int enemyDamage;


public int EnemyHealth 
{
    get
    {
        return enemyHealth;
    }

    set
    {
        enemyHealth = value;
    }
}

public int EnemyDamage
{

    get
    {
        return enemyDamage;
    }

    set
    {
        enemyDamage = value;
    }
}

public Enemy(int enemyHealth, int enemyDamage)
{
    this.enemyHealth = enemyHealth;
    this.enemyDamage = enemyDamage;
} 

}
}
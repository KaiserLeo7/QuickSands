using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

public int enemyDamage
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

public Enemy(int hp, int dam)
{
    this.enemyHealth = hp;
    this.enemyDamage = dam;
} 

}
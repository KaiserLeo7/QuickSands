using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script sets the values of the unit and its animation

public class Unit : MonoBehaviour
{
    //unit values
    public string unitName;
    public int unitLevel;

    public int damage;

    public int maxHP;
    public int currentHP;


    public bool TakeDamage(int dmg) {
        currentHP -= dmg;

        if (currentHP <= 0)
        {
            currentHP = 100;
            return true;
        }
        else { 
            return false;
        }
    }

    public void Heal(int healAmount)
    {
        currentHP += healAmount;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }

    public int GetHealth() {
        return currentHP;
    }
    
}
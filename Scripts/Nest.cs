using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : Location
{
    private Enemy enemySet{get;}


    public Nest(string name, double lattitude, double longtitude, int enemyName, int damage) : base(name, lattitude, longtitude)
    {
        enemySet = new Enemy(enemyName, enemySet);

    }



}



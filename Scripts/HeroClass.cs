using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroClass : MonoBehaviour
{
    private string hero{get;}
    
    public HeroClass(int heroID)
    {
        if(heroID == 1)
            hero = "Warrior";
        else if(heroID == 2)
            hero = "Ranger";
        else if(heroID == 3)
            hero = "Mage";
    }
}

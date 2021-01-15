using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands

{
    public class CharacterSelect
    {
        private HeroClassDB hero;
        private HeroPartyDB party;

    

    // add ranger class to party database
    public class addRanger(){
        Hero ranger = hero.getHero(1);
        party.addHero(ranger);
    }

    //add warrior class to party database
    public class addWarrior(){
         Hero warrior = hero.getHero(0);
         party.addHero(warrior);
    }

    //add mage class to party database
    public class addMage(){
         Hero mage = hero.getHero(2);
         party.addHero(mage);
    }

}

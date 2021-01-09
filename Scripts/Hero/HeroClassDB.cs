using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Sands {
    public static class HeroClassDB {

        public static List<Hero> heroes = new List<Hero>();

        static HeroClassDB() 
        {
            heroes = new List<Hero>() {
                //adding all 3 types off heroes to sample class
                //  int damage, int critDamage, int maxHP, int currentHP, int capacity
                   new Warrior(100, 10, 500, 500, 100),
                   new Ranger( 100, 33, 350, 350, 75),
                   new Mage(   200, 15, 200, 200, 60)
            };
        }

        //get database
        public static List<Hero> getHeroList() {
            return heroes;
        }

        //get Hero at position
        public static Hero getHero(int position) {
          return heroes[position];
        }

        //clear
        public static void clearHeroList() {
            heroes.Clear();
        }
    }
}
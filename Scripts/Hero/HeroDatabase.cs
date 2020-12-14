using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class HeroDatabase {

        private static List<Hero> heroes = new List<Hero>();

        //get database
        public List<Hero> getHeroList() {
            return heroes;
        }

        //get Hero at position
        public Hero getHero(int position) {
          return heroes[position];
        }
    

        //insert
        public List<Hero> insertHero(Hero hero) {
            if (unitName != null)
            heroes.Add(hero);

            return heroes;
        }

        //delete
        public List<Hero> deleteHero(Hero hero) {
            for (int i = 0; i < heroes.lenght; i++) {

                if (heroes[i].unitName == hero.unitName)
                    heroes.RemoveAt(i);
            }
            return heroes;
        }

        //clear
        public void clearHeroList() {
            heroes.RemoveAll();
        }
    }
}
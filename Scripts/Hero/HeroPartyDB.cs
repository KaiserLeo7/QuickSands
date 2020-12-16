using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class HeroPartyDB {

        private List<Hero> heroParty = new List<Hero>();

        //get database
        public List<Hero> getHeroList() {
            return heroParty;
        }

        //get Hero at position
        public Hero getHero(int position) {
            return heroParty[position];
        }


        //insert
        public List<Hero> insertHero(Hero hero) {
            if (unitName != null)
                heroParty.Add(hero);

            return heroParty;
        }

        //delete
        public List<Hero> deleteHero(Hero hero) {
            return heroParty = heroParty.Except(heroParty.Where(h => h.unitName == hero.unitName)).ToList();
        }

        //clear
        public void clearHeroList() {
            heroParty.Clear();
        }
    }
}
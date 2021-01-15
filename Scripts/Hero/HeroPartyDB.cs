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

        //clear
        public void clearHeroList() {
            heroParty.Clear();
        }

        //add a hero to the party
        public void addHero(Hero hero) {
            heroParty.add(hero);
        }
    }
}
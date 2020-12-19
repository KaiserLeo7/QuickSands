using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Sands {
    public class HeroClassDB : MonoBehaviour {

        public List<Hero> heroes = new List<Hero>();

        void Awake() {
            BuildClassDatabase();
        }

        void BuildClassDatabase() 
        {
            heroes = new List<Hero>() {
                //int heroID, string heroClass, int heroLevel, int damage, double critDamage, int maxHP, int currentHP
                   new Hero("Warrior", 1, 100, 10.0, 500, 500),
                   new Hero("Ranger",  1, 50, 33.0, 350, 350),
                   new Hero("Mage",    1, 250, 15.0, 200, 200)
            };
        }
        

        //get database
        public List<Hero> getHeroList() {
            return heroes;
        }

        //get Hero at position
        public Hero getHero(int position) {
          return heroes[position];
        }
    
        //delete
        public List<Hero> deleteHero(Hero hero) {
            return heroes = heroes.Except(heroes.Where(h => h.unitName == hero.unitName)).ToList();
        }

        //clear
        public void clearHeroList() {
            heroes.Clear();
        }
    }
}
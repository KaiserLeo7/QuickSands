using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class DeliveryQuest : Quest {

        private LocationDB locationDB;
    
        LocationDB locationList = locationDB.getLocationList();

        public DeliveryQuest(string questDescription, string questLocation, int questReward) {

        }

        void Awake() {
            BuildClassDatabase();
        }

        void BuildClassDatabase() 
        {
            quests = new List<locationList>() {
            //int damage, double critDamage, int maxHealth, int currentHealth
            

            };
        }

        


        }
    }
}
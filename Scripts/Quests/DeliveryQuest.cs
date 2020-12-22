using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class DeliveryQuest : Quest
    {

        private LocationDB locationDB = new LocationDB();


        public DeliveryQuest(string questDescription, string questLocation, int questReward)
        {

            List<Location> locationList = locationDB.getLocationList();

        }

        void Awake()
        {
            BuildClassDatabase();
        }

        void BuildClassDatabase()
        {
            quests = new List<locationList>()
            {
                //int damage, double critDamage, int maxHealth, int currentHealth


            };
        }




    }
}

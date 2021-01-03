using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class DeliveryQuest : Quest
    {

        private LocationDB locationDB = new LocationDB();

        private System.Random random = new System.Random();

        private  itemDatabase = new ItemDatabase();
        private Item chosenItem;
        public DeliveryQuest(string questDescription, string questLocation, int questReward)
        {
            this.chosenItem = itemDatabase.getItem(random.Next(35, 46));
            this.questReward = random.Next();
          this.questDescription = "Deliver " +   item + "to " + random.locationlist - currentlocation;

          //run locat

           

        }





    }
}

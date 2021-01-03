using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class DeliveryQuest : Quest
    {

        private LocationDB locationDB = new LocationDB();

        private System.Random random = new System.Random();

<<<<<<< HEAD
        public DeliveryQuest(string questDescription, string questLocation, int questReward)
        {
            this.questReward = random.Next();
          //  this.questDescription = "Deliver " + random (random tear) item + "to "
          // + random.locationlist - currentlocation;
=======
        private ItemDatabase itemDatabase = new ItemDatabase();

        public DeliveryQuest(string questDescription, string questLocation, int questReward)
        {
            this.questReward = random.Next();
          this.questDescription = "Deliver " + random.Next(random tear) item + "to " + random.locationlist - currentlocation;
>>>>>>> parent of 7db1937... wtf 2.0

          //run locat

           

        }





    }
}

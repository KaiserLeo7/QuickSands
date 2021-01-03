using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class DeliveryQuest : Quest
    {

        private LocationDB locationDB = new LocationDB();

        private System.Random random = new System.Random();

        private TradeableDatabase tradeableDatabase = new TradeableDatabase();
        private Tradeable chosenTradeable;
        private Location chosenLocation;
        int[] amount = new int[]{50, 45, 40, 35, 30, 25, 20, 15, 10, 5};
        public DeliveryQuest(string questDescription, string questLocation, int questReward)
        {
          chosenTradeable = tradeableDatabase.getTradeable(random.Next(1, 11));
          
          this.questReward = random.Next();
          do
          {
            chosenLocation = locationDB.getLocation(random.Next(1, 11));
          } while (chosenLocation != currentLocation);
          this.questDescription = "Deliver " +  chosenTradeable.ItemName + "to " + chosenLocation.LocationName;

          //run locat

           

        }





    }
}

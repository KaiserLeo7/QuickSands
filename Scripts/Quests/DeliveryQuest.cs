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
        private PlayerData playerData = new PlayerData();
        private Tradeable chosenTradeable;
        private Location chosenLocation;
        //parallel array of item delivery amounts based on tradeable id
        int[] amount = new int[] { 50, 45, 40, 35, 30, 25, 20, 15, 10, 5 };


        public DeliveryQuest(string questDescription, string questLocation, int questReward)
        {
            //chooses a random tradable from the database
            chosenTradeable = tradeableDatabase.getTradeable(random.Next(1, 11));

            //if current location is the same as the chosen one find another
            do
            {
                chosenLocation = locationDB.getLocation(random.Next(1, 11));
            } while (chosenLocation.LocationName == playerData.CurrentLocation.LocationName);

            //description based on other parameters
            this.questDescription = "Deliver " + amount[chosenLocation.Id - 1] + " of " + chosenTradeable.ItemName + "to " + chosenLocation.LocationName;

            //checks whether our locations are connected
            bool connected = false;

            //price based on the location distance
                //checks if the locations are connected
            foreach (int location in playerData.CurrentLocation.NearbyTowns)
            {
                if (chosenLocation.Id == location)
                {
                    connected = true;
                }
            }

            //sets the price for a CONNECTED destination location 
            if (connected)
            {
                    this.questReward = random.Next(200, 301);
            }
            //sets the price for a NOT CONNECTED destination location 
            else
            {
                //if they're NOT in the same territory
                if (playerData.CurrentLocation.Territory != chosenLocation.Territory)
                    this.questReward = random.Next(400, 501);
                //if they ARE in the same territory
                else
                    this.questReward = random.Next(300, 401);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class PlayerData : MonoBehaviour {

        private static Location currentLocation;

        private QuestDatabase database;

        private static List<Quest> acceptedQuests = new List<Quest>();
        public PlayerData() {}

       
        public Location CurrentLocation {
            get {
                return currentLocation;
            }
            set {
                currentLocation = value;
            }
        }

    //need a check for if the current location has changed
    //if it has then check the quests if their delivery location is the current location
    //then check if the items are in your inventory
    //if all prerequisites are met subtract the items from inventory
    //add the reward value to the players money

        //get database
        public List<Quest> getAcceptedQuestList() {
            return acceptedQuests;
        }

        //get Quest at position
        public Quest getAcceptedQuest(int position) {
            return acceptedQuests[position];
        }

        //add Quest
        public void addAcceptedQuest() {
             acceptedQuests.Add(database.getQuest(needs a quest without number));
        }

    }
}  

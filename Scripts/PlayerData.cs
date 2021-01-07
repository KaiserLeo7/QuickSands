using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class PlayerData : MonoBehaviour {

        private static Location currentLocation;

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

        public List<Quest> AcceptedQuests {
            get {
                return acceptedQuests;
            }
            set {
                acceptedQuests = value;
            }
        }

    //need a check for if the current location has changed
    //if it has then check the quests if their delivery location is the current location
    //then check if the items are in your inventory
    //if all prerequisites are met subtract the items from inventory
    //add the reward value to the players money

        //get Quest at position
        public Quest getAcceptedQuest(int position) {
            return acceptedQuests[position];
        }

    }
}  

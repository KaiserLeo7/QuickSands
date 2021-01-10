using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    [System.Serializable]
    public class PlayerData
    {
        private Location currentLocation;
        private List<Quest> acceptedQuests;

        public PlayerData(){
            
        }

        public PlayerData(Player player){
            this.currentLocation = player.CurrentLocation;
            this.acceptedQuests = player.AcceptedQuests;

        }

        public PlayerData(bool [] nestsStatus){
            this.nestsStatus[] = nestsStatus;
           
        }

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
    }
}

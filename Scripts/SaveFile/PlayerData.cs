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
        private List<Nest> nests = new List<Nest>();

        public PlayerData(){
            
        }

        public PlayerData(Player player){
            this.currentLocation = player.CurrentLocation;
            this.acceptedQuests = player.AcceptedQuests;
        }

        public PlayerData(NestList nestList){
            this.nests = nestList.getNestList();
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

        public List<Nest> Nests {
            get {
                return nests;
            }
            set {
                nests = value;
            }
        }
    }
}

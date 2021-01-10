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

        public PlayerData(Player player){
            this.currentLocation = player.CurrentLocation;
            this.acceptedQuests = player.AcceptedQuests;
        }
    }
}

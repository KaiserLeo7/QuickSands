using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class PlayerData : MonoBehaviour {

        private static Location currentLocation;
        public PlayerData() {}

       
        public Location CurrentLocation {
            get {
                return currentLocation;
            }
            set {
                currentLocation = value;
            }
        }

    }
}  

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Quest : MonoBehaviour {
        private LootPicker lootpicker;

        private string questDescription;
        
        private string questLocation;

        private int questReward;

        public Quest() {}

        
        /////////// GETTERS AND SETTERS //////////
        public string QuestName {
            get {
                return questDescription;
            }
            set {
                questDescription = value;
            }
        }

        public string QuestLocation {
            get {
                return questLocation;
            }
            set {
                questLocation = value;
            }
        }

        public int QuestReward {
            get {
                return questReward;
            }
            set {
                questReward = value;
            }
        }
    }
}  

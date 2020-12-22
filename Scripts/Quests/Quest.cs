using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Quest : MonoBehaviour {
        private LootPicker lootpicker;

        private string questDescription;
        
        private string questLocation;

        private int questReward;

        public Quest(string questDescription, string questLocation, int questReward) {

            this.questDescription = questDescription;
            this.questLocation = questLocation;
            this.questReward = questReward;

        }

        
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

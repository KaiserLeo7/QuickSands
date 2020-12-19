using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Quest : MonoBehaviour {
        LootPicker lootpicker;

        string questName;
        
        string questLocation;

        int questReward;

        Quest(string questName, string questLocation, int questReward) {

            this.questName = questName;
            this.questLocation = questLocation;
            this.questReward = questReward;

        }

        
        /////////// GETTERS AND SETTERS //////////
        public string QuestName {
            get {
                return questName;
            }
            set {
                questName = value;
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

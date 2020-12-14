using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Quest : MonoBehaviour {
        LootPicker lootpicker;

        int questID;
        string questName;
        string questType;
        
        string questLocation;

        int questReward;

        Quest(int questID, string questName, string questType,
            string questLocation, int questReward) {

            this.questID = questID;
            this.questName = questName;
            this.questType = questType;
            this.questLocation = questLocation;
            this.questReward = questReward;

        }

        
        /////////// GETTERS AND SETTERS //////////

        public double QuestID {
            get {
                return questID;
            }
            set {
                questID = value;
            }
        }

        public double QuestName {
            get {
                return questName;
            }
            set {
                questName = value;
            }
        }

        public double QuestType {
            get {
                return questType;
            }
            set {
                questType = value;
            }
        }
        

        public double QuestLocation {
            get {
                return questLocation;
            }
            set {
                questLocation = value;
            }
        }

        public double QuestReward {
            get {
                return questReward;
            }
            set {
                questReward = value;
            }
        }
    }
}  

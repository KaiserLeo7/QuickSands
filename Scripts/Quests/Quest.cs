using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class Quest : MonoBehaviour {
        protected LootPicker lootpicker;

        protected string questDescription;
        
        protected string questLocation;

        protected int questReward;

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

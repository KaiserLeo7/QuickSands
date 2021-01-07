using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class QuestDatabase {

        private List<Quest> quests = new List<Quest>();

        //calls the battle quest and delivery quests up to 5 times
        //the quests are genrated each time the player enters a town and are not regenerated before reaching a new town
        //get database
        public List<Quest> getQuestList() {
            return quests;
        }

        //get Hero at position
        public Quest getQuest(int position) {
            return quests[position];
        }

        //clear
        public void clearQuestList() {
            quests.Clear();
        }
    }
}
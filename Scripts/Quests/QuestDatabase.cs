using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class QuestDatabase {

        private static List<Quest> quests = new List<Quest>();

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
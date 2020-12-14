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


        //insert
        public List<Quest> insertQuest(Quest quest) {
            if (questID != null)
                quests.Add(quest);

            return quests;
        }

        //delete
        public List<Quest> deleteQuest(Quest quest) {
            for (int i = 0; i < quests.lenght; i++) {

                if (quests[i].questID == hero.questID)
                    quests.RemoveAt(i);
            }
            return quests;
        }

        //clear
        public void clearQuestList() {
            quests.RemoveAll();
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands {
    public class QuestGiver {

        private PlayerData playerData = new PlayerData();
        private List<Quest> quests = new List<Quest>();
        private NestDB nestDB = new NestDB();
        public void populateQuestList(){
            for (int i = 0; i < 4; i++)
                quests.Add(new DeliveryQuest());
            
            BattleQuest quest;
            // if(playerData.AcceptedQuests.Count > 0)
            // {
            //     do
            // {
            //     quest = new BattleQuest();

            //     foreach 
            // } while (playerData.AcceptedQuests.Contains(quest));
            foreach (Nest nest in nestDB.getNestList())
            {
                if (nest.ac)
                {
                    
                }
            }
                quests.Add(quest);
            }
            
        }
    }
}

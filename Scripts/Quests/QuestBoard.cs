using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class QuestBoard
    {

        private PlayerData playerData = new PlayerData();
        private List<Quest> quests = new List<Quest>();
        private System.Random random = new System.Random();

        private NestDB nestDB = new NestDB();
       
        public void populateQuestList()
        {
            for (int i = 0; i < 4; i++)
                quests.Add(new DeliveryQuest());


        List<Nest> trueNestList = new List<Nest>();


            foreach (Nest nest in nestDB.getNestList())
            {
                

                //need to check if all nests are active
                //if all nest are active then generate 5th delivery instead of battle
                //is any nests are not active generate a battle quest
                //also check the nests that are not active and only
                // allow for the generation of only those nests as battlequests
                
                //if nest in nestDB is active if not its false and add to new list
                if (nest.ActiveStatus)
                {
                    trueNestList.Add(nest);
                }

                
            }

            if(trueNestList.Count > 0) {
                BattleQuest battleQuest = new BattleQuest();
                bool again = false;
                do{

                  //only generate a battleQuest with available NestDB locations
                  
                    foreach (Quest quest in playerData.AcceptedQuests)
                    {
                        if (quest.QuestLocation.LocationName == battleQuest.QuestLocation.LocationName)
                        {
                            again = true;
                        }
                    }

                    foreach (Nest nest in trueNestList)
                    {
                        if (nest.LocationName == battleQuest.QuestLocation.LocationName)
                        {
                            again = true;
                        }
                    }
                   
                } while (again);
                quests.Add(battleQuest);
            }
            else{
                quests.Add(new DeliveryQuest());
            }
        }     
    }
}



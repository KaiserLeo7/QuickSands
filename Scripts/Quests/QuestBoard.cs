using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class QuestBoard
    {

        private PlayerData playerData = new PlayerData();
        private List<Quest> quests = new List<Quest>();
        private NestDB nestDB = new NestDB();
        public void populateQuestList()
        {
            for (int i = 0; i < 4; i++)
                quests.Add(new DeliveryQuest());

            BattleQuest battleQuest;
            bool nestsStatus = false;
            foreach (Nest nest in nestDB.getNestList())
            {
                if (nest.ActiveStatus)
                {
                    nestsStatus = true;
                }
            }
        }
            // if(playerData.AcceptedQuests.Count > 0)
            // {
            //     do
            // {
            //     quest = new BattleQuest();

            //     foreach 
            // } while (playerData.AcceptedQuests.Contains(quest));
           
            
            
        }
    }



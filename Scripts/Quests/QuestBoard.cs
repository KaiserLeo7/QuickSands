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


        List<Nest> falseNestList = new List<Nest>();


            foreach (Nest nest in nestDB.getNestList())
            {
                

                //need to check if all nests are active
                //if all nest are active then generate 5th delivery instead of battle
                //is any nests are not active generate a battle quest
                //also check the nests that are not active and only
                // allow for the generation of only those nests as battlequests
                
                //if nest in nestDB is active if not its false and add to new list
                if (!nest.ActiveStatus)
                {
                    falseNestList.Add(nest);
                }

                
            }

            if(falseNestList.Count > 0) {
                do{

                   int nestNumber =  random.Next(0, falseNestList.Count)
                  //only generate a battleQuest with available NestDB locations
                  falseNestList[];
                  
                  BattleQuest battleQuest = new BattleQuest();

                   
                } while (playerData.AcceptedQuests.Contains(quest));
           
            }
        }
            // if(playerData.AcceptedQuests.Count > 0)
            // {
            //     
            
            
        }
    }



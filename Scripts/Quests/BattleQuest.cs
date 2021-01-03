using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sands
{
    public class BattleQuest : Quest
    {
        public BattleQuest(string questLocation, int questReward, string questDescription = "defeat enemies at location")
        {
            this.questDescription = questDescription;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Quest
    {
        public string Name { get; set; }
        public string InfoText { get; set; }
        public int RewardExperience { get; set; }
        public int RewardEssence { get; set; }
        public Item? RewardItem { get; set; }
        public bool IsCompleted { get; set; }

        public Quest(string name, string infoText, int rewardExperience, int rewardEssence, bool isCompleted, Item? rewardItem = null)
        {
            Name = name;
            InfoText = infoText;
            RewardExperience = rewardExperience;
            RewardEssence = rewardEssence;
            IsCompleted = isCompleted;
            RewardItem = rewardItem;
        }
    }
}

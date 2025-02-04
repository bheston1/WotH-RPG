using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class QuestManager
    {
        // Act 1
        public static Quest missingVillagers = new Quest(name: "Missing Villagers", infoText: "Investigate the disappearances of the village residents.", rewardExperience: 150, rewardEssence: 200, isCompleted: false, rewardItem: ItemManager.oldKey);

        public static Quest hermitsRelic = new Quest(name: "The Mad Hermit's Relic", infoText: "Retrieve a lost relic from the forest for the Mad Hermit.", rewardExperience: 300, rewardEssence: 300, isCompleted: false, rewardItem: ItemManager.occultDagger);

        public static Quest echoesOfThePast = new Quest(name: "Echoes of the Past", infoText: "Find and return the village's journal to Elder Rook.", rewardExperience: 350, rewardEssence: 250, isCompleted: false, rewardItem: null);

        public static Quest childsToy = new Quest(name: "The Drowned Child's Toy", infoText: "Retrieve the lost toy of the drowned child from the well.", rewardExperience: 300, rewardEssence: 250, isCompleted: false, rewardItem: null);

        public static Quest cursedBlood = new Quest(name: "Cursed Blood", infoText: "Help Mira uncover the truth about her family's involvement in the curse.", rewardExperience: 400, rewardEssence: 500, isCompleted: false, rewardItem: null);

        public static Quest hollowsBane = new Quest(name: "The Hollow's Bane", infoText: "Kill a dangerous creature in the Whispering Groves.", rewardExperience: 750, rewardEssence: 1000, isCompleted: false, rewardItem: null);

        public static Quest unseenHunter = new Quest(name: "The Unseen Hunter", infoText: "Track down a mysterious predator in Hollow's Edge.", rewardExperience: 500, rewardEssence: 1000, isCompleted: false, rewardItem: null);
    }
}

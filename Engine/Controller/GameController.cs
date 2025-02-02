using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;

namespace Engine.Controller
{
    public class GameController
    {
        public Player Player { get; private set; }
        public Monster? CurrentMonster { get; private set; }

        public GameController()
        {
            MapManager.GenerateMap();
            ItemManager.PopulateCraftables();
            Player = new(name: "Player", level: 1, experience: 0, xpToLevel: 100, health: 100, maxHealth: 100, mana: 50, maxMana: 50, minDamage: 1, maxDamage: 10, spellAdjust: 1f, critChance: 5, defense: 0, magicResist: 0, essence: 0, currentWeapon: null, headSlot: null, bodySlot: null, offHand: null, neckSlot: null, ringSlot: null, currentLocation: MapManager.survivorsRetreat);
            Player.Inventory.Add(ItemManager.longSword);
            Player.Inventory.Add(ItemManager.smallHealthPotion);
            Player.Inventory.Add(ItemManager.smallHealthPotion);
            Player.Inventory.Add(ItemManager.smallHealthPotion);
            Player.Spells.Add(ItemManager.flame);
            Player.Spells.Add(ItemManager.heal);
            Player.Inventory.Add(ItemManager.rope);
            Player.Inventory.Add(ItemManager.bucket);
        }

        public bool MonsterFound()
        {
            if (Player.CurrentLocation.MapArea.HasMonsters == true && Player.CurrentLocation.EncountersDisabled == false)
            {
                foreach (Monster monster in Player.CurrentLocation.MapArea.Monsters)
                {
                    if (Helpers.GetNumberBetween(1, 100) <= monster.EncounterChance)
                    {
                        CurrentMonster = (Monster)monster.Clone();
                        return true;
                    }
                }
            }

            return false;
        }

        // TODO: Some form of fast travel e.g., an item that can move player between rest sites.

        // TODO: Player XP/level system

        // TODO: Implement status effect system

        // TODO: All balancing is fucked. Do a proper go at adjusting stats on player, monsters, items, spells, etc.
        // also make sure spell caster monsters have their spells in list, or will crash during combat if they try to cast

        /* 
         * Bulk of the logic being used in the forms needs to be handled here/other controllers.
         * TODO: See above, and refactor the shit out of this mess.
         */

        // TODO: Much of the bulk in the models could probably be condensed --> inheritance/interfaces
    }
}

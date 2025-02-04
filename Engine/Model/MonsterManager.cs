using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class MonsterManager
    {

        // Act 1
        public static Monster hollowFiend = new Monster(name: "Hollow Fiend", health: 5, maxHealth: 5, mana: 0, maxMana: 0, minDamage: 2, maxDamage: 3, spellAdjust: 1f, critChance: 5, defense: 0, magicResist: 0, rewardXp: 6, rewardEssence: 12, encounterChance: 50, isSpellCaster: false, chanceToEscape: 100);

        public static Monster hollowStalker = new Monster(name: "Hollow Stalker", health: 6, maxHealth: 6, mana: 0, maxMana: 0, minDamage: 3, maxDamage: 5, spellAdjust: 1f, critChance: 10, defense: 1, magicResist: 0, rewardXp: 8, rewardEssence: 16, encounterChance: 30, isSpellCaster: false, chanceToEscape: 80);

        public static Monster corruptedWolf = new Monster(name: "Corrupted Wolf", health: 12, maxHealth: 12, mana: 0, maxMana: 0, minDamage: 5, maxDamage: 7, spellAdjust: 1f, critChance: 15, defense: 2, magicResist: 0, rewardXp: 16, rewardEssence: 32, encounterChance: 20, isSpellCaster: false, chanceToEscape: 60);

        public static Monster forsakenVillager = new Monster(name: "Forsaken Villager", health: 21, maxHealth: 21, mana: 0, maxMana: 0, minDamage: 10, maxDamage: 12, spellAdjust: 1f, critChance: 5, defense: 5, magicResist: 0, rewardXp: 28, rewardEssence: 42, encounterChance: 60, isSpellCaster: false, chanceToEscape: 80);

        public static Monster cursedSpirit = new Monster(name: "Cursed Spirit", health: 21, maxHealth: 21, mana: 10, maxMana: 10, minDamage: 7, maxDamage: 9, spellAdjust: 1f, critChance: 5, defense: 6, magicResist: 20, rewardXp: 30, rewardEssence: 46, encounterChance: 40, isSpellCaster: true, chanceToEscape: 80);

        public static Monster whisperingShadow = new Monster(name: "Whispering Shadow", health: 15, maxHealth: 15, mana: 0, maxMana: 0, minDamage: 12, maxDamage: 15, spellAdjust: 1f, critChance: 5, defense: 9, magicResist: 20, rewardXp: 42, rewardEssence: 63, encounterChance: 60, isSpellCaster: false, chanceToEscape: 70);

        public static Monster forestGhoul = new Monster(name: "Forest Ghoul", health: 17, maxHealth: 17, mana: 0, maxMana: 0, minDamage: 13, maxDamage: 16, spellAdjust: 1f, critChance: 10, defense: 10, magicResist: 0, rewardXp: 50, rewardEssence: 89, encounterChance: 40, isSpellCaster: false, chanceToEscape: 70);

        public static Monster wretchedFungus = new Monster(name: "Wretched Fungus", health: 30, maxHealth: 30, mana: 0, maxMana: 0, minDamage: 18, maxDamage: 21, spellAdjust: 1f, critChance: 5, defense: 13, magicResist: 0, rewardXp: 75, rewardEssence: 120, encounterChance: 50, isSpellCaster: false, chanceToEscape: 60);

        public static Monster wardenHound = new Monster(name: "Hollow Warden's Hound", health: 33, maxHealth: 33, mana: 0, maxMana: 0, minDamage: 23, maxDamage: 25, spellAdjust: 1f, critChance: 20, defense: 14, magicResist: 20, rewardXp: 97, rewardEssence: 153, encounterChance: 30, isSpellCaster: false, chanceToEscape: 50);

        public static Monster corruptedTreant = new Monster(name: "Corrupted Treant", health: 40, maxHealth: 40, mana: 0, maxMana: 0, minDamage: 30, maxDamage: 32, spellAdjust: 1f, critChance: 10, defense: 15, magicResist: 0, rewardXp: 134, rewardEssence: 267, encounterChance: 20, isSpellCaster: false, chanceToEscape: 70);
    }
}

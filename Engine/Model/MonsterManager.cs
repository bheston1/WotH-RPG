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
        public static Monster hollowFiend = new Monster(name: "Hollow Fiend", health: 20, maxHealth: 20, mana: 0, maxMana: 0, minDamage: 1, maxDamage: 10, spellAdjust: 1f, critChance: 5, defense: 0, magicResist: 0, rewardXp: 14, rewardEssence: 28, encounterChance: 50, isSpellCaster: false, chanceToEscape: 100);

        public static Monster hollowStalker = new Monster(name: "Hollow Stalker", health: 9, maxHealth: 9, mana: 0, maxMana: 0, minDamage: 5, maxDamage: 7, spellAdjust: 1f, critChance: 10, defense: 1, magicResist: 0, rewardXp: 18, rewardEssence: 36, encounterChance: 30, isSpellCaster: false, chanceToEscape: 80);

        public static Monster corruptedWolf = new Monster(name: "Corrupted Wolf", health: 11, maxHealth: 11, mana: 0, maxMana: 0, minDamage: 7, maxDamage: 9, spellAdjust: 1f, critChance: 15, defense: 2, magicResist: 0, rewardXp: 22, rewardEssence: 44, encounterChance: 20, isSpellCaster: false, chanceToEscape: 60);

        public static Monster forsakenVillager = new Monster(name: "Forsaken Villager", health: 16, maxHealth: 16, mana: 0, maxMana: 0, minDamage: 12, maxDamage: 14, spellAdjust: 1f, critChance: 5, defense: 5, magicResist: 0, rewardXp: 32, rewardEssence: 64, encounterChance: 60, isSpellCaster: false, chanceToEscape: 80);

        public static Monster cursedSpirit = new Monster(name: "Cursed Spirit", health: 18, maxHealth: 18, mana: 10, maxMana: 10, minDamage: 14, maxDamage: 16, spellAdjust: 1f, critChance: 5, defense: 6, magicResist: 20, rewardXp: 36, rewardEssence: 74, encounterChance: 40, isSpellCaster: true, chanceToEscape: 80);

        public static Monster whisperingShadow = new Monster(name: "Whispering Shadow", health: 23, maxHealth: 23, mana: 0, maxMana: 0, minDamage: 16, maxDamage: 18, spellAdjust: 1f, critChance: 5, defense: 9, magicResist: 20, rewardXp: 46, rewardEssence: 92, encounterChance: 60, isSpellCaster: false, chanceToEscape: 70);

        public static Monster forestGhoul = new Monster(name: "Forest Ghoul", health: 25, maxHealth: 25, mana: 0, maxMana: 0, minDamage: 18, maxDamage: 20, spellAdjust: 1f, critChance: 5, defense: 10, magicResist: 0, rewardXp: 50, rewardEssence: 100, encounterChance: 40, isSpellCaster: false, chanceToEscape: 70);

        public static Monster wretchedFungus = new Monster(name: "Wretched Fungus", health: 30, maxHealth: 30, mana: 0, maxMana: 0, minDamage: 26, maxDamage: 28, spellAdjust: 1f, critChance: 5, defense: 13, magicResist: 0, rewardXp: 60, rewardEssence: 120, encounterChance: 50, isSpellCaster: false, chanceToEscape: 60);

        public static Monster wardenHound = new Monster(name: "Hollow Warden's Hound", health: 32, maxHealth: 32, mana: 0, maxMana: 0, minDamage: 28, maxDamage: 30, spellAdjust: 1f, critChance: 20, defense: 14, magicResist: 20, rewardXp: 64, rewardEssence: 128, encounterChance: 30, isSpellCaster: false, chanceToEscape: 50);

        public static Monster corruptedTreant = new Monster(name: "Corrupted Treant", health: 34, maxHealth: 34, mana: 0, maxMana: 0, minDamage: 30, maxDamage: 32, spellAdjust: 1f, critChance: 10, defense: 15, magicResist: 0, rewardXp: 68, rewardEssence: 136, encounterChance: 20, isSpellCaster: false, chanceToEscape: 70);
    }
}

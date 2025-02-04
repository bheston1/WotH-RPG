using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class ItemManager
    {
        public static readonly List<Item> CraftableItems = new();

        // Misc & key items
        public static Item oldKey = new Item(name: "Old Key", infoText: "An old key for an old lock.", value: 15, dropChance: null, firstIngredient: null, secondIngredient: null, usedForCrafting: false);

        public static Item rope = new Item(name: "Rope", infoText: "Sturdy rope. Useful for many things.", value: 2, dropChance: null, firstIngredient: null, secondIngredient: null, usedForCrafting: true);

        public static Item bucket = new Item(name: "Bucket", infoText: "Great for carrying liquids!", value: 3, dropChance: null, firstIngredient: null, secondIngredient: null, usedForCrafting: true);

        public static Item ropeBucket = new Item(name: "Rope Bucket", infoText: "A bucket with a rope attached to the handle.", value: 5, dropChance: null, firstIngredient: rope, secondIngredient: bucket, usedForCrafting: false);

        public static Item lifeRoot = new Item(name: "Liferoot", infoText: "A plant with healing properties.", value: 5, dropChance: 25, firstIngredient: null, secondIngredient: null, usedForCrafting: true);

        public static Item corpseWeed = new Item(name: "Corpseweed", infoText: "An herb with magical properties.", value: 5, dropChance: 25, firstIngredient: null, secondIngredient: null, usedForCrafting: true);

        public static Item boneDust = new Item(name: "Bone Dust", infoText: "Secondary alchemical ingredient used to make various minor potions.", value: 2, dropChance: 50, firstIngredient: null, secondIngredient: null, usedForCrafting: true);

        // Weapons
        public static Weapon startingSpear = new Weapon(name: "Handmade Spear", infoText: "A stick with a pointy rock at the tip.", value: 10, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 1, maxDamage: 3, weaponEffect: null, critChanceBonus: 0, usedForCrafting: false);

        public static Weapon occultDagger = new Weapon(name: "Occult Dagger", infoText: "Knife used for dark rituals.", value: 60, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 3, maxDamage: 5, weaponEffect: "25% Crit. Chance", critChanceBonus: 25, usedForCrafting: false);

        public static Weapon ironLongsword = new Weapon(name: "Iron Longsword", infoText: "Stury iron blade.", value: 180, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 8, maxDamage: 12, weaponEffect: null, critChanceBonus: 0, usedForCrafting: false);

        public static Weapon heavyBattleaxe = new Weapon(name: "Heavy Battleaxe", infoText: "Made of steel, and very heavy.", value: 560, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 14, maxDamage: 16, weaponEffect: null, critChanceBonus: 0, usedForCrafting: false);

        public static Weapon lance = new Weapon(name: "Lance", infoText: "Big metal poker.", value: 1500, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 18, maxDamage: 22, weaponEffect: null, critChanceBonus: 0, usedForCrafting: false);

        // Armor
        public static Armor clothHood = new Armor(name: "Cloth Hood", infoText: "Keeps your head slightly warm.", value: 5, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 1, armorEffect: null, slot: "Head", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor travelerClothes = new Armor(name: "Traveler Clothes", infoText: "Not much for protection, but it's better than being naked.", value: 5, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 1, armorEffect: null, slot: "Body", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor leatherCap = new Armor(name: "Leather Cap", infoText: "Slightly better than cloth.", value: 35, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 2, armorEffect: null, slot: "Head", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor hideArmor = new Armor(name: "Hide Armor", infoText: "Made from animal skin.", value: 35, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 2, armorEffect: null, slot: "Body", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor chainCoif = new Armor(name: "Chain Coif", infoText: "Chainmail headpiece.", value: 150, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 4, armorEffect: null, slot: "Head", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor chainArmor = new Armor(name: "Chain Armor", infoText: "Suit of armor made of chainmail.", value: 150, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 6, armorEffect: null, slot: "Body", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor platedHelm = new Armor(name: "Plated Helm", infoText: "Helmet made from iron.", value: 500, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 6, armorEffect: null, slot: "Head", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Armor platedArmor = new Armor(name: "Plated Armor", infoText: "Iron plate armor.", value: 500, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 10, armorEffect: null, slot: "Body", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        // Jewelry
        public static Jewelry defenseAmulet = new Jewelry(name: "Amulet of Defense", infoText: "Boosts defense.", value: 50, dropChance: null, firstIngredient: null, secondIngredient: null, effect: "+2 defense", slot: "Neck", defenseBonus: 2, magResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        public static Jewelry assassinPendant = new Jewelry(name: "Assassin's Pendant", infoText: "Boost crit. chance.", value: 75, dropChance: null, firstIngredient: null, secondIngredient: null, effect: "+10% crit. chance", "Neck", defenseBonus: 0, magResistBonus: 0, critChanceBonus: 10, spellAdjBonus: 0, usedForCrafting: false);

        public static Jewelry apprenticeAmulet = new Jewelry(name: "Apprentice's Amulet", infoText: "Boosts spell power.", value: 60, dropChance: null, firstIngredient: null, secondIngredient: null, effect: "+25% spell adjust", slot: "Neck", defenseBonus: 0, magResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0.25f, usedForCrafting: false);

        public static Jewelry protectionRing = new Jewelry(name: "Ring of Protection", infoText: "Boosts defense.", value: 50, dropChance: null, firstIngredient: null, secondIngredient: null, effect: "+2 defense", slot: "Ring", defenseBonus: 2, magResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0, usedForCrafting: false);

        // Spells
        public static Spell heal = new Spell(name: "Minor Heal", infoText: "Restores 30 HP.", manaCost: 3, damage: null, healAmount: 30, usableOutOfCombat: true, isHealingSpell: true, utility: null);

        public static Spell flame = new Spell(name: "Flame", infoText: "A weak fire spell.", manaCost: 6, damage: 20, healAmount: null, usableOutOfCombat: false, isHealingSpell: false, utility: null);

        // Consumables
        // add some stat-boosting items that apply permanently
        public static Consumable smallHealthPotion = new Consumable(name: "Small Healing Potion", infoText: "Restores 25% health.", value: 10, dropChance: null, effect: "25% Heal", firstIngredient: lifeRoot, secondIngredient: boneDust, isCombatItem: true, usedForCrafting: false);

        public static Consumable smallManaPotion = new Consumable(name: "Small Mana Potion", infoText: "Restores 25% mana.", value: 10, dropChance: null, effect: "25% Mana", firstIngredient: corpseWeed, secondIngredient: boneDust, isCombatItem: true, usedForCrafting: false);

        public static void PopulateCraftables()
        {
            CraftableItems.Add(smallHealthPotion);
            CraftableItems.Add(ropeBucket);
            CraftableItems.Add(smallManaPotion);
        }
    }
}

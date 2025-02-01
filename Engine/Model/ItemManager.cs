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
        public static Item oldKey = new Item(name: "Old Key", infoText: "An old key for an old lock.", value: 15, dropChance: null, firstIngredient: null, secondIngredient: null);

        public static Item rope = new Item(name: "Rope", infoText: "Sturdy rope. Useful for many things.", value: 2, dropChance: null, firstIngredient: null, secondIngredient: null);

        public static Item bucket = new Item(name: "Bucket", infoText: "Great for carrying liquids!", value: 3, dropChance: null, firstIngredient: null, secondIngredient: null);

        public static Item ropeBucket = new Item(name: "Rope Bucket", infoText: "A bucket with a rope attached to the handle.", value: 5, dropChance: null, firstIngredient: rope, secondIngredient: bucket);

        public static Item lifeRoot = new Item(name: "Liferoot", infoText: "A plant with healing properties.", value: 5, dropChance: 25, firstIngredient: null, secondIngredient: null);

        public static Item corpseWeed = new Item(name: "Corpseweed", infoText: "An herb with magical properties.", value: 5, dropChance: 25, firstIngredient: null, secondIngredient: null);

        public static Item boneDust = new Item(name: "Bone Dust", infoText: "Secondary alchemical ingredient used to make various minor potions.", value: 2, dropChance: 50, firstIngredient: null, secondIngredient: null);

        // Weapons
        public static Weapon longSword = new Weapon(name: "Longsword", infoText: "Sturdy sword with an iron blade.", value: 25, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 3, maxDamage: 6, weaponEffect: null, critChanceBonus: 0);

        public static Weapon occultDagger = new Weapon(name: "Occult Dagger", infoText: "Dagger enchanted with dark magic.", value: 20, dropChance: null, firstIngredient: null, secondIngredient: null, minDamage: 3, maxDamage: 6, weaponEffect: null, critChanceBonus: 0);

        // Armor
        public static Armor clothHood = new Armor(name: "Cloth Hood", infoText: "Keeps your head slightly warm.", value: 5, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 1, armorEffect: null, slot: "Head", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0);

        public static Armor travelerClothes = new Armor(name: "Traveler Clothes", infoText: "Not much for protection, but it's better than being naked.", value: 10, dropChance: null, firstIngredient: null, secondIngredient: null, defenseBonus: 1, armorEffect: null, slot: "Body", magicResistBonus: 0, critChanceBonus: 0, spellAdjBonus: 0);

        // Jewelry

        // Spells
        public static Spell heal = new Spell(name: "Heal", infoText: "Heals for 25% health.", manaCost: 15, damage: null, healAmount: 0.25f, usableOutOfCombat: true, isHealingSpell: true, utility: null);

        public static Spell cleanse = new Spell(name: "Cleanse", infoText: "Removes harmful status effects.", manaCost: 10, damage: null, healAmount: null, usableOutOfCombat: true, isHealingSpell: null, utility: "Cleanse");

        public static Spell flame = new Spell(name: "Flame", infoText: "A weak fire spell with a small chance to inflict burn.", manaCost: 10, damage: 15, healAmount: null, usableOutOfCombat: false, isHealingSpell: false, utility: null);

        // Consumables
        // add some stat-boosting items that apply permanently
        public static Consumable smallHealthPotion = new Consumable(name: "Small Healing Potion", infoText: "Restores 25% health.", value: 10, dropChance: null, effect: "25% Heal", firstIngredient: lifeRoot, secondIngredient: boneDust, isCombatItem: true);

        public static Consumable smallManaPotion = new Consumable(name: "Small Mana Portion", infoText: "Restores 25% mana.", value: 10, dropChance: null, effect: "25% Mana", firstIngredient: corpseWeed, secondIngredient: boneDust, isCombatItem: true);

        public static Consumable healSpellBook = new Consumable(name: "Spellbook: Heal", infoText: "Use to learn the spell 'Heal' spell.", value: 500, dropChance: 5, firstIngredient: null, secondIngredient: null, "Add Spell: Heal", isCombatItem: false);

        public static void PopulateCraftables()
        {
            CraftableItems.Add(smallHealthPotion);
            CraftableItems.Add(ropeBucket);
            CraftableItems.Add(smallManaPotion);
        }
    }
}

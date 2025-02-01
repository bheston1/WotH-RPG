using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Armor : Item
    {
        public int DefenseBonus { get; set; }
        public string? ArmorEffect { get; set; }
        public string Slot { get; set; }
        public int MagResistBonus { get; set; }
        public int CritChanceBonus { get; set; }
        public float SpellAdjBonus { get; set; }

        public Armor(string name, string infoText, int? value, int? dropChance, Item? firstIngredient, Item? secondIngredient, int defenseBonus, string? armorEffect, string slot, int magicResistBonus, int critChanceBonus, float spellAdjBonus, bool usedForCrafting) : base(name, infoText, value, dropChance, firstIngredient, secondIngredient, usedForCrafting)
        {
            DefenseBonus = defenseBonus;
            ArmorEffect = armorEffect;
            Slot = slot;
            MagResistBonus = magicResistBonus;
            CritChanceBonus = critChanceBonus;
            SpellAdjBonus = spellAdjBonus;
        }
    }
}

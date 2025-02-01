using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Jewelry : Item
    {
        public string Effect { get; set; }
        public string Slot { get; set; }
        public int DefenseBonus { get; set; }
        public int MagResistBonus { get; set; }
        public int CritChanceBonus { get; set; }
        public float SpellAdjBonus { get; set; }

        public Jewelry(string name, string infoText, int? value, int? dropChance, Item? firstIngredient, Item? secondIngredient, string effect, string slot, int defenseBonus, int magResistBonus, int critChanceBonus, float spellAdjBonus, bool usedForCrafting) : base(name, infoText, value, dropChance, firstIngredient, secondIngredient, usedForCrafting)
        {
            Effect = effect;
            Slot = slot;
            DefenseBonus = defenseBonus;
            MagResistBonus = magResistBonus;
            CritChanceBonus = critChanceBonus;
            SpellAdjBonus = spellAdjBonus;
        }
    }
}

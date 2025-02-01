using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string? WeaponEffect { get; set; }
        public int? StatusChance { get; set; }
        public int CritChanceBonus { get; set; }

        public Weapon(string name, string infoText, int? value, int? dropChance, Item? firstIngredient, Item? secondIngredient, int minDamage, int maxDamage, string? weaponEffect, int critChanceBonus) : base(name, infoText, value, dropChance, firstIngredient, secondIngredient)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            WeaponEffect = weaponEffect;
            CritChanceBonus = critChanceBonus;
        }
    }
}

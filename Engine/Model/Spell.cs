using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Spell
    {
        public string Name { get; set; }
        public string InfoText { get; set; }
        public int ManaCost { get; set; }
        public int? Damage { get; set; }
        public float? HealAmount { get; set; }
        public bool UsableOutOfCombat { get; set; }
        public bool? IsHealingSpell { get; set; }
        public string? Utility { get; set; }

        public Spell(string name, string infoText, int manaCost, int? damage, float? healAmount, bool usableOutOfCombat, bool? isHealingSpell, string? utility)
        {
            Name = name;
            InfoText = infoText;
            ManaCost = manaCost;
            Damage = damage;
            HealAmount = healAmount;
            UsableOutOfCombat = usableOutOfCombat;
            IsHealingSpell = isHealingSpell;
            Utility = utility;
        }

        public void TriggerUtility(Player player)
        {
            switch (Utility)
            {
                case "":
                    break;

                default:
                    Console.WriteLine("Nothing happens.");
                    break;
            }
        }
    }
}

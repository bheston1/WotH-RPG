using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Monster : ICloneable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public float SpellAdjust { get; set; } // spell potency
        public int CritChance { get; set; } // crits deal x2 damage
        public int Defense { get; set; } // flat reduction of normal damage
        public int MagicResist { get; set; } // percent magic damage reduction
        public int RewardXp { get; set; }
        public int RewardEssence { get; set; }
        public List<Spell> Spells { get; set; }
        public int? EffectChance { get; set; }
        public List<Item> LootItems { get; set; }
        public int? EncounterChance { get; set; }
        public bool IsSpellCaster { get; set; }
        public int ChanceToEscape { get; set; }

        public Monster(string name, int health, int maxHealth, int mana, int maxMana, int minDamage, int maxDamage, float spellAdjust, int critChance, int defense, int magicResist, int rewardXp, int rewardEssence, int? encounterChance, bool isSpellCaster, int chanceToEscape)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Mana = mana;
            MaxMana = maxMana;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            SpellAdjust = spellAdjust;
            CritChance = critChance;
            Defense = defense;
            MagicResist = magicResist;
            RewardXp = rewardXp;
            RewardEssence = rewardEssence;
            LootItems = new();
            Spells = new();
            EncounterChance = encounterChance;
            IsSpellCaster = isSpellCaster;
            ChanceToEscape = chanceToEscape;
        }

        public object Clone() // from ICloneable: monsters are static, so need this to get a new object each encounter
        {
            return new Monster(Name, Health, MaxHealth, Mana, MaxMana, MinDamage, MaxDamage, SpellAdjust, CritChance, Defense, MagicResist, RewardXp, RewardEssence, EncounterChance, IsSpellCaster, ChanceToEscape)
            {
                Health = MaxHealth // ensure hp gets reset
            };
        }

        public int Hurt(int damage, int magicDamage)
        {
            int d = damage - Defense;
            int md = magicDamage * (1 - MagicResist / 100);
            if (Defense > d && damage != 0)
            {
                d = 1;
            }
            int total = d + md;
            Health = Math.Max(Health - total, 0);
            return total;
        }

        public void Heal(int amount)
        {
            Health = Math.Min(Health + amount, MaxHealth);
        }

        public void Heal(float percent)
        {
            int amount = (int)(MaxHealth * percent);
            Health = Math.Min(Health + amount, MaxHealth);
        }

        public int CastSpell(Spell spell, Player player)
        {
            int damage = 0;
            if (spell.Damage != null)
            {
                Mana -= spell.ManaCost;
                damage = (int)(spell.Damage * SpellAdjust);
            }
            return damage;
        }

        public int Attack(Player player)
        {
            Random r = new();
            int damage = r.Next(MinDamage, MaxDamage);
            switch (CheckForCritical())
            {
                case true:
                    damage *= 2;
                    break;

                case false:
                    break;
            }
            return damage;
        }

        private bool CheckForCritical()
        {
            if (Helpers.GetNumberBetween(1, 100) <= CritChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Player
    {
        private readonly int[] experienceTable =
        {
            0,
            7,
            23,
            47,
            110,
            220,
            450,
            800,
            1300,
            2000
        };

        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; }
        public int Experience { get; set; }
        public int XpToLevel { get; set; }
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
        public int Essence { get; set; } // "money"
        public List<Item> Inventory { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Consumable> Consumables { get; set; }
        public Weapon? CurrentWeapon { get; set; }
        public Armor? HeadSlot { get; set; }
        public Armor? BodySlot { get; set; }
        public Armor? OffHand { get; set; }
        public Jewelry? NeckSlot { get; set; }
        public Jewelry? RingSlot { get; set; }
        public List<Quest> QuestLog { get; set; }
        public Room CurrentLocation { get; set; }
        public bool HasRequiredItem = true;

        public Player(string name, int level, int maxLevel, int experience, int xpToLevel, int health, int maxHealth, int mana, int maxMana, int minDamage, int maxDamage, float spellAdjust, int critChance, int defense, int magicResist, int essence, Weapon? currentWeapon, Armor? headSlot, Armor? bodySlot, Armor? offHand, Jewelry? neckSlot, Jewelry? ringSlot, Room currentLocation)
        {
            Name = name;
            Level = level;
            MaxLevel = maxLevel;
            Experience = experience;
            XpToLevel = xpToLevel;
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
            Essence = essence;
            CurrentWeapon = currentWeapon;
            HeadSlot = headSlot;
            BodySlot = bodySlot;
            OffHand = offHand;
            NeckSlot = neckSlot;
            RingSlot = ringSlot;
            CurrentLocation = currentLocation;
            Inventory = new();
            Spells = new();
            QuestLog = new();
            Consumables = new();
        }

        public event Action<int> OnLevelUp;

        public void AddXP(int amount)
        {
            Experience += amount;
            CheckForLevelUp();
        }

        private void CheckForLevelUp()
        {
            while (Level < experienceTable.Length - 1 && Experience >= experienceTable[Level])
            {
                Level++;
                ApplyLevelBonuses();
                OnLevelUp?.Invoke(Level);
            }
        }

        private void ApplyLevelBonuses()
        {
            switch (Level)
            {
                case 2:
                    MaxHealth += 3;
                    MinDamage += 1;
                    MaxDamage += 1;
                    break;

                case 3:
                    if (!Spells.Contains(ItemManager.heal))
                    {
                        Spells.Add(ItemManager.heal);
                    }
                    MaxHealth += 4;
                    MinDamage += 2;
                    MaxDamage += 2;
                    MaxMana += 3;
                    break;

                case 4:
                    MaxHealth += 2;
                    MinDamage += 1;
                    MaxDamage += 1;
                    MaxMana += 3;
                    break;

                case 5:
                    MaxHealth += 4;
                    MinDamage += 3;
                    MaxDamage += 3;
                    MaxMana += 6;
                    break;

                case 6:
                    if (!Spells.Contains(ItemManager.flame))
                    {
                        Spells.Add(ItemManager.flame);
                    }
                    MaxHealth += 3;
                    MinDamage += 2;
                    MaxDamage += 2;
                    MaxMana += 6;
                    break;

                case 7:
                    MaxHealth += 3;
                    MinDamage += 1;
                    MaxDamage += 1;
                    MaxMana += 9;
                    break;

                case 8:
                    MaxHealth += 5;
                    MinDamage += 3;
                    MaxDamage += 3;
                    MaxMana += 9;
                    break;

                case 9:
                    MaxHealth += 5;
                    MinDamage += 2;
                    MaxDamage += 2;
                    MaxMana += 12;
                    break;

                case 10:
                    MaxHealth += 6;
                    MinDamage += 3;
                    MaxDamage += 3;
                    MaxMana += 12;
                    break;
            }
        }
        
        public int GetXpToLevel()
        {
            switch (Level)
            {
                case 1:
                    return experienceTable[1];

                case 2:
                    return experienceTable[2];

                case 3:
                    return experienceTable[3];

                case 4:
                    return experienceTable[4];

                case 5:
                    return experienceTable[5];

                case 6:
                    return experienceTable[6];

                case 7:
                    return experienceTable[7];

                case 8:
                    return experienceTable[8];

                case 9:
                    return experienceTable[9];

                case 10:
                    return experienceTable[10];
            }

            return 0;
        }

        public int Hurt(int damage, int magicDamage)
        {
            int defense = GetDefense();
            int d = damage - defense;
            int md = magicDamage * (1 - GetMagicResist() / 100);
            if (defense > d && damage != 0)
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

        public void RestoreMana(int amount)
        {
            Mana = Math.Min(Mana + amount, MaxMana);
        }

        public void RestoreMana(float percent)
        {
            int amount = (int)(MaxMana * percent);
            Mana = Math.Min(Mana + amount, MaxMana);
        }

        public int CastSpell(Spell spell, Monster monster)
        {
            int damage = 0;
            if (spell.Damage != null)
            {
                Mana -= spell.ManaCost;
                damage = (int)(spell.Damage * GetSpellAdjust());
            }
            return damage;
        }

        public void CastSpell(Spell spell)
        {
            if (spell.HealAmount != null)
            {
                Mana -= spell.ManaCost;
                int amount = (int)(spell.HealAmount * MaxHealth);
                Heal(amount);
            }
            else if (spell.HealAmount == null)
            {
                Mana -= spell.ManaCost;
                spell.TriggerUtility(this);
            }
        }

        public int Attack(Monster monster)
        {
            int damage = GetDamage();
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
            if (Helpers.GetNumberBetween(1, 100) <= GetCritChance())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCritChance()
        {
            int head = 0;
            int body = 0;
            int offHand = 0;
            int neck = 0;
            int ring = 0;
            int weapon = 0;
            if (HeadSlot != null) head = HeadSlot.CritChanceBonus;
            if (BodySlot != null) body = BodySlot.CritChanceBonus;
            if (OffHand != null) offHand = OffHand.CritChanceBonus;
            if (NeckSlot != null) neck = NeckSlot.CritChanceBonus;
            if (RingSlot != null) ring = RingSlot.CritChanceBonus;
            if (CurrentWeapon != null) weapon = CurrentWeapon.CritChanceBonus;
            int total = CritChance + head + body + offHand + neck + ring + weapon;
            return total;
        }

        public int GetMagicResist()
        {
            int head = 0;
            int body = 0;
            int offHand = 0;
            int neck = 0;
            int ring = 0;
            if (HeadSlot != null) head = HeadSlot.MagResistBonus;
            if (BodySlot != null) body = BodySlot.MagResistBonus;
            if (OffHand != null) offHand = OffHand.MagResistBonus;
            if (NeckSlot != null) neck = NeckSlot.MagResistBonus;
            if (RingSlot != null) ring = RingSlot.MagResistBonus;
            int total = MagicResist + head + body + offHand + neck + ring;
            return total;
        }

        public float GetSpellAdjust()
        {
            float head = 0;
            float body = 0;
            float offHand = 0;
            float neck = 0;
            float ring = 0;
            if (HeadSlot != null) head = HeadSlot.SpellAdjBonus;
            if (BodySlot != null) body = BodySlot.SpellAdjBonus;
            if (OffHand != null) offHand = OffHand.SpellAdjBonus;
            if (NeckSlot != null) neck = NeckSlot.SpellAdjBonus;
            if (RingSlot != null) ring = RingSlot.SpellAdjBonus;
            float total = SpellAdjust + head + body + offHand + neck + ring;
            return total;
        }
        
        public void Rest()
        {
            Health = MaxHealth;
            Mana = MaxMana;
        }

        public void Equip(Weapon weapon)
        {
            CurrentWeapon = weapon;
        }

        public void Unequip(Weapon weapon)
        {
            CurrentWeapon = null;
        }

        public void Unequip(Armor armor)
        {
            switch (armor.Slot)
            {
                case "Head":
                    HeadSlot = null;
                    break;

                case "Body":
                    BodySlot = null;
                    break;

                case "Offhand":
                    OffHand = null;
                    break;
            }
        }

        public void Equip(Armor armor)
        {
            switch (armor.Slot)
            {
                case "Head":
                    HeadSlot = armor;
                    break;

                case "Body":
                    BodySlot = armor;
                    break;

                case "Offhand":
                    OffHand = armor;
                    break;
            }
        }

        public void Equip(Jewelry jewelry)
        {
            switch (jewelry.Slot)
            {
                case "Neck":
                    NeckSlot = jewelry;
                    break;

                case "Ring":
                    RingSlot = jewelry;
                    break;
            }
        }

        public void Unequip(Jewelry jewelry)
        {
            switch (jewelry.Slot)
            {
                case "Neck":
                    NeckSlot = null;
                    break;

                case "Ring":
                    RingSlot = null;
                    break;
            }
        }

        public int GetDamage()
        {
            Random r = new();
            if (CurrentWeapon != null)
            {
                return r.Next(MinDamage, MaxDamage) + r.Next(CurrentWeapon.MinDamage, CurrentWeapon.MaxDamage);
            }
            else
            {
                return r.Next(MinDamage, MaxDamage);
            }
        }

        public int GetDefense()
        {
            int head = 0;
            int body = 0;
            int offHand = 0;
            int neck = 0;
            int ring = 0;
            if (HeadSlot != null) head = HeadSlot.DefenseBonus;
            if (BodySlot != null) body = BodySlot.DefenseBonus;
            if (OffHand != null) offHand = OffHand.DefenseBonus;
            if (NeckSlot != null) neck = NeckSlot.DefenseBonus;
            if (RingSlot != null) ring = RingSlot.DefenseBonus;
            int total = Defense + head + body + offHand + neck + ring;
            return total;
        }

        public void Move(string direction)
        {
            Room? targetRoom = direction.ToLower() switch
            {
                "north" => CurrentLocation.North,
                "east" => CurrentLocation.East,
                "south" => CurrentLocation.South,
                "west" => CurrentLocation.West,
                _ => null
            };

            if (targetRoom != null && targetRoom.RequiredAccessItem != null)
            {
                if (Inventory.Contains(targetRoom.RequiredAccessItem))
                {
                    CurrentLocation = targetRoom;
                }
                else if (!Inventory.Contains(targetRoom.RequiredAccessItem))
                {
                    HasRequiredItem = false;
                    CurrentLocation = CurrentLocation;
                }
            }
            else if (targetRoom != null)
            {
                CurrentLocation = targetRoom;
            }
        }
    }
}

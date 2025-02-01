using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Consumable : Item
    {
        public string? Effect { get; set; }
        public bool IsCombatItem { get; set; }

        public Consumable(string name, string infoText, int? value, int? dropChance, Item? firstIngredient, Item? secondIngredient, string? effect, bool isCombatItem, bool usedForCrafting) : base(name, infoText, value, dropChance, firstIngredient, secondIngredient, usedForCrafting)
        {
            Effect = effect;
            IsCombatItem = isCombatItem;
        }

        public void Use(Player player)
        {
            switch (Effect)
            {
                case "25% Heal":
                    player.Heal(0.25f);
                    player.Inventory.Remove(this);
                    break;

                case "25% Mana":
                    player.RestoreMana(0.25f);
                    player.Inventory.Remove(this);
                    break;

                case "Add Spell: Heal":
                    if (!player.Spells.Contains(ItemManager.heal)) player.Spells.Add(ItemManager.heal);
                    player.Inventory.Remove(this);
                    break;

                default:
                    Console.WriteLine("Nothing happens.");
                    break;
            }
        }
    }
}

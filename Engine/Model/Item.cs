using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Item
    {
        public string Name { get; set; }
        public string InfoText { get; set; }
        public int? Value { get; set; }
        public int? DropChance { get; set; }
        public Item? FirstIngredient { get; set; }
        public Item? SecondIngredient{ get; set; }

        public Item(string name, string infoText, int? value, int? dropChance, Item? firstIngredient, Item? secondIngredient)
        {
            Name = name;
            InfoText = infoText;
            Value = value;
            DropChance = dropChance;
            FirstIngredient = firstIngredient;
            SecondIngredient = secondIngredient;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class NPC
    {
        public string Name { get; set; }
        public bool IsTrader { get; set; }
        bool IsAlive { get; set; }
        bool AlreadyMet { get; set; }
        public List<Item>? ForSale { get; set; }

        public NPC(string name, bool isTrader, bool isAlive, bool alreadyMet)
        {
            Name = name;
            IsTrader = isTrader;
            IsAlive = isAlive;
            AlreadyMet = alreadyMet;
            if (isTrader == true) ForSale = new();
        }
    }
}

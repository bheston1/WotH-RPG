using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class NPCManager
    {
        public static NPC elderRook = new NPC(name: "Elder Rook", isTrader: true, isAlive: true, alreadyMet: false);
        public static NPC mira = new NPC(name: "Mira", isTrader: false, isAlive: true, alreadyMet: false);
    }
}

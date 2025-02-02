using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class NPCManager
    {
        public static string[] rookDialog =
        {
            
        };

        public static NPC elderRook = new NPC(name: "Elder Rook", isTrader: true, isAlive: true, alreadyMet: false);

        public static NPC mira = new NPC(name: "Mira", isTrader: false, isAlive: true, alreadyMet: false);

        public static NPC hollowWarden = new NPC(name: "The Hollow Warden", isTrader: false, isAlive: true, alreadyMet: false);

        public static NPC madHermit = new NPC(name: "Mad Hermit", isTrader: false, isAlive: true, alreadyMet: false);

        public static NPC drownedChild = new NPC(name: "Drowned Child", isTrader: false, isAlive: true, alreadyMet: false);
    }
}

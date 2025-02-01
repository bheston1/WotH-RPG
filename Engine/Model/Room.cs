using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class Room
    {
        public MapArea MapArea { get; set; }
        public Room? North { get; set; }
        public Room? East { get; set; }
        public Room? South { get; set; }
        public Room? West { get; set; }
        public bool HasChest { get; set; }
        public bool HasItem { get; set; }
        public Item? RequiredAccessItem { get; set; }
        public bool EncountersDisabled { get; set; }
        public bool RestArea { get; set; }
        public bool BossRoom { get; set; }
        public bool HasNpc { get; set; }
        public bool HasTrader { get; set; }
        public List<NPC> NPCs { get; set; }

        public Room(MapArea mapArea, bool hasChest, bool hasItem, bool encountersDisabled, bool restArea, bool bossRoom, bool hasNpc, bool hasTrader)
        {
            MapArea = mapArea;
            HasChest = hasChest;
            HasItem = hasItem;
            RequiredAccessItem = null;
            North = null;
            East = null;
            South = null;
            West = null;
            EncountersDisabled = encountersDisabled;
            RestArea = restArea;
            BossRoom = bossRoom;
            HasNpc = hasNpc;
            HasTrader = hasTrader;
            NPCs = new();
        }
    }
}

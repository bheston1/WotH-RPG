using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public static class MapManager
    {
        // Act 1
        private static MapArea survivorCamp = new(name: "Survivor's Retreat", hasMonsters: false);
        private static MapArea hollowsEdge = new(name: "Hollow's Edge", hasMonsters: true);
        private static MapArea whisperingGroves = new(name: "Whispering Groves", hasMonsters: true);
        private static MapArea abandonedVillage = new(name: "Abandoned Village", hasMonsters: true);
        private static MapArea forgottenSrhine = new(name: "Forgotten Shrine", hasMonsters: false);
        private static MapArea oldBridge = new(name: "Old Bridge", hasMonsters: false);
        private static MapArea deepHollow = new(name: "Deep Hollow", hasMonsters: true);

        public static Room survivorsRetreat = new Room(mapArea: survivorCamp, hasChest: false, hasItem: false, encountersDisabled: true, restArea: true, bossRoom: false, hasNpc: true, hasTrader: true);

        public static Room hollowsEdge1 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge2 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge3 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge4 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge5 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge6 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge7 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge8 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge9 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge10 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge11 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge12 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge13 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge14 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge15 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge16 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge17 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge18 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge19 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge20 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false,  encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge21 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge22 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge23 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge24 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge25 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room hollowsEdge26 = new Room(mapArea: hollowsEdge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves1 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves2 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves3 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves4 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves5 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves6 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves7 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves8 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves9 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves10 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves11 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves12 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves13 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves14 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves15 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves16 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves17 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves18 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves19 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves20 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves21 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves22 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves23 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room whisperingGroves24 = new Room(mapArea: whisperingGroves, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage1 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage2 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage3 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage4 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage5 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage6 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage7 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage8 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage9 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage10 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage11 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage12 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage13 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage14 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room abandonedVillage15 = new Room(mapArea: abandonedVillage, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine1 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine2 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine3 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine4 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine5 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine6 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine7 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine8 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room forgottenShrine9 = new Room(mapArea: forgottenSrhine, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room deepHollow1 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room deepHollow2 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow3 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow4 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow5 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow6 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow7 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow8 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow9 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow10 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow11 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow12 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow13 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow14 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow15 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow16 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow17 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow18 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow19 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);
        
        public static Room deepHollow20 = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: false, hasTrader: false);

        public static Room wardenBridge = new Room(mapArea: oldBridge, hasChest: false, hasItem: false, encountersDisabled: false, restArea: false, bossRoom: false, hasNpc: true, hasTrader: false);

        public static Room hollowsHeart = new Room(mapArea: deepHollow, hasChest: false, hasItem: false, encountersDisabled: true, restArea: false, bossRoom: true, hasNpc: false, hasTrader: false);

        // Act 2


        // Act 3


        public static void GenerateMap()
        {
            PopulateMap();
            EstablishRoomConnections();
            AssignRoomRequirements();
        }

        private static void EstablishRoomConnections()
        {
            survivorsRetreat.North = hollowsEdge1;
            survivorsRetreat.East = abandonedVillage1;

            hollowsEdge1.North = hollowsEdge2;
            hollowsEdge1.South = survivorsRetreat;

            hollowsEdge2.North = hollowsEdge4;
            hollowsEdge2.South = hollowsEdge1;

            hollowsEdge3.North = hollowsEdge7;

            hollowsEdge4.North = hollowsEdge9;
            hollowsEdge4.East = hollowsEdge5;
            hollowsEdge4.South = hollowsEdge2;

            hollowsEdge5.North = hollowsEdge10;
            hollowsEdge5.East = hollowsEdge6;
            hollowsEdge5.West = hollowsEdge4;

            hollowsEdge6.East = hollowsEdge7;
            hollowsEdge6.West = hollowsEdge5;

            hollowsEdge7.North = hollowsEdge12;
            hollowsEdge7.West = whisperingGroves1;
            hollowsEdge7.West = hollowsEdge6;
            hollowsEdge7.South = hollowsEdge3;

            hollowsEdge8.North = hollowsEdge14;
            hollowsEdge8.East = hollowsEdge9;

            hollowsEdge9.East = hollowsEdge10;
            hollowsEdge9.South = hollowsEdge4;
            hollowsEdge9.West = hollowsEdge8;

            hollowsEdge10.North = hollowsEdge15;
            hollowsEdge10.South = hollowsEdge5;
            hollowsEdge10.West = hollowsEdge9;

            hollowsEdge11.East = hollowsEdge12;

            hollowsEdge12.South = hollowsEdge7;
            hollowsEdge12.West = hollowsEdge11;

            hollowsEdge13.East = hollowsEdge14;
            hollowsEdge13.West = wardenBridge;

            hollowsEdge14.North = hollowsEdge17;
            hollowsEdge14.South = hollowsEdge8;
            hollowsEdge14.West = hollowsEdge13;

            hollowsEdge15.West = hollowsEdge16;
            hollowsEdge15.South = hollowsEdge10;

            hollowsEdge16.North = hollowsEdge19;
            hollowsEdge16.West = hollowsEdge15;

            hollowsEdge17.North = hollowsEdge20;
            hollowsEdge17.East = hollowsEdge18;
            hollowsEdge17.South = hollowsEdge14;

            hollowsEdge18.West = hollowsEdge17;

            hollowsEdge19.North = hollowsEdge23;
            hollowsEdge19.South = hollowsEdge16;

            hollowsEdge20.North = hollowsEdge24;
            hollowsEdge20.East = hollowsEdge21;
            hollowsEdge20.South = hollowsEdge17;

            hollowsEdge21.North = forgottenShrine2;
            hollowsEdge21.East = hollowsEdge22;
            hollowsEdge21.West = hollowsEdge20;

            hollowsEdge22.North = hollowsEdge25;
            hollowsEdge22.East = hollowsEdge23;
            hollowsEdge22.West = hollowsEdge21;

            hollowsEdge23.South = hollowsEdge19;
            hollowsEdge23.West = hollowsEdge22;

            hollowsEdge24.South = hollowsEdge20;

            hollowsEdge25.East = hollowsEdge26;
            hollowsEdge25.South = hollowsEdge22;

            hollowsEdge26.West = hollowsEdge25;

            abandonedVillage1.East = abandonedVillage4;
            abandonedVillage1.South = abandonedVillage2;
            abandonedVillage1.West = survivorsRetreat;

            abandonedVillage2.North = abandonedVillage1;
            abandonedVillage2.East = abandonedVillage5;

            abandonedVillage3.East = abandonedVillage6;
            abandonedVillage3.South = abandonedVillage4;

            abandonedVillage4.North = abandonedVillage3;
            abandonedVillage4.East = abandonedVillage7;
            abandonedVillage4.South = abandonedVillage5;
            abandonedVillage4.West = abandonedVillage1;

            abandonedVillage5.North = abandonedVillage4;
            abandonedVillage5.East = abandonedVillage8;
            abandonedVillage5.West = abandonedVillage2;

            abandonedVillage6.East = abandonedVillage9;
            abandonedVillage6.South = abandonedVillage7;
            abandonedVillage6.West = abandonedVillage3;

            abandonedVillage7.North = abandonedVillage6;
            abandonedVillage7.East = abandonedVillage10;
            abandonedVillage7.South = abandonedVillage8;
            abandonedVillage7.West = abandonedVillage4;

            abandonedVillage8.North = abandonedVillage7;
            abandonedVillage8.East = abandonedVillage11;
            abandonedVillage8.West = abandonedVillage5;

            abandonedVillage9.South = abandonedVillage10;
            abandonedVillage9.West = abandonedVillage6;

            abandonedVillage10.North = abandonedVillage9;
            abandonedVillage10.South = abandonedVillage11;
            abandonedVillage10.West = abandonedVillage7;

            abandonedVillage11.North = abandonedVillage10;
            abandonedVillage11.South = abandonedVillage12;
            abandonedVillage11.West = abandonedVillage8;

            abandonedVillage12.North = abandonedVillage11;
            abandonedVillage12.East = abandonedVillage14;
            abandonedVillage12.South = abandonedVillage13;

            abandonedVillage13.North = abandonedVillage12;
            abandonedVillage13.East = abandonedVillage15;

            abandonedVillage14.South = abandonedVillage15;
            abandonedVillage14.West = abandonedVillage12;

            abandonedVillage15.North = abandonedVillage14;
            abandonedVillage15.West = abandonedVillage13;

            whisperingGroves1.North = whisperingGroves2;
            whisperingGroves1.East = whisperingGroves4;
            whisperingGroves1.West = hollowsEdge7;

            whisperingGroves2.North = whisperingGroves3;
            whisperingGroves2.East = whisperingGroves5;
            whisperingGroves2.South = whisperingGroves1;

            whisperingGroves3.South = whisperingGroves2;

            whisperingGroves4.West = whisperingGroves1;

            whisperingGroves5.East = whisperingGroves6;
            whisperingGroves5.West = whisperingGroves2;

            whisperingGroves6.North = whisperingGroves7;
            whisperingGroves6.East = whisperingGroves11;
            whisperingGroves6.West = whisperingGroves5;

            whisperingGroves7.North = whisperingGroves8;
            whisperingGroves7.East = whisperingGroves12;
            whisperingGroves7.South = whisperingGroves6;

            whisperingGroves8.South = whisperingGroves7;

            whisperingGroves9.North = whisperingGroves10;
            whisperingGroves9.East = whisperingGroves13;

            whisperingGroves10.North = whisperingGroves11;
            whisperingGroves10.East = whisperingGroves14;
            whisperingGroves10.South = whisperingGroves9;

            whisperingGroves11.North = whisperingGroves12;
            whisperingGroves11.East = whisperingGroves15;
            whisperingGroves11.South = whisperingGroves10;
            whisperingGroves11.West = whisperingGroves6;

            whisperingGroves12.South = whisperingGroves11;
            whisperingGroves12.West = whisperingGroves7;

            whisperingGroves13.East = whisperingGroves17;
            whisperingGroves13.West = whisperingGroves9;

            whisperingGroves14.North = whisperingGroves15;
            whisperingGroves14.East = whisperingGroves18;
            whisperingGroves14.West = whisperingGroves10;

            whisperingGroves15.South = whisperingGroves14;
            whisperingGroves15.West = whisperingGroves11;

            whisperingGroves16.East = whisperingGroves21;

            whisperingGroves17.North = whisperingGroves18;
            whisperingGroves17.East = whisperingGroves13;

            whisperingGroves18.North = whisperingGroves19;
            whisperingGroves18.South = whisperingGroves17;
            whisperingGroves18.West = whisperingGroves14;

            whisperingGroves19.East = whisperingGroves22;
            whisperingGroves19.South = whisperingGroves18;

            whisperingGroves20.North = whisperingGroves21;
            whisperingGroves20.East = whisperingGroves23;

            whisperingGroves21.East = whisperingGroves24;
            whisperingGroves21.West = whisperingGroves16;

            whisperingGroves22.North = whisperingGroves23;
            whisperingGroves22.West = whisperingGroves19;

            whisperingGroves23.South = whisperingGroves22;
            whisperingGroves23.West = whisperingGroves20;

            whisperingGroves24.West = whisperingGroves21;

            forgottenShrine1.North = forgottenShrine4;
            forgottenShrine1.East = forgottenShrine2;

            forgottenShrine2.North = forgottenShrine5;
            forgottenShrine2.East = forgottenShrine3;
            forgottenShrine2.South = hollowsEdge21;
            forgottenShrine2.West = forgottenShrine1;

            forgottenShrine3.North = forgottenShrine6;
            forgottenShrine3.West = forgottenShrine2;

            forgottenShrine4.North = forgottenShrine7;
            forgottenShrine4.East = forgottenShrine5;
            forgottenShrine4.South = forgottenShrine1;

            forgottenShrine5.North = forgottenShrine8;
            forgottenShrine5.East = forgottenShrine6;
            forgottenShrine5.South = forgottenShrine2;
            forgottenShrine5.West = forgottenShrine4;

            forgottenShrine6.North = forgottenShrine9;
            forgottenShrine6.South = forgottenShrine3;
            forgottenShrine6.West = forgottenShrine5;

            forgottenShrine7.East = forgottenShrine8;
            forgottenShrine7.South = forgottenShrine4;

            forgottenShrine8.East = forgottenShrine9;
            forgottenShrine8.South = forgottenShrine5;
            forgottenShrine8.West = forgottenShrine7;

            forgottenShrine9.South = forgottenShrine6;
            forgottenShrine9.West = forgottenShrine8;

            deepHollow1.East = wardenBridge;
            deepHollow1.West = deepHollow2;

            deepHollow2.North = deepHollow3;
            deepHollow2.East = deepHollow1;
            deepHollow2.West = deepHollow4;

            deepHollow3.South = deepHollow2;

            deepHollow4.East = deepHollow2;
            deepHollow4.West = deepHollow5;

            deepHollow5.East = deepHollow4;
            deepHollow5.West = deepHollow6;

            deepHollow6.East = deepHollow5;
            deepHollow6.South = deepHollow7;

            deepHollow7.North = deepHollow6;
            deepHollow7.East = deepHollow8;
            deepHollow7.South = deepHollow9;

            deepHollow8.West = deepHollow7;

            deepHollow9.North = deepHollow7;
            deepHollow9.East = deepHollow10;

            deepHollow10.East = deepHollow11;
            deepHollow10.West = deepHollow9;

            deepHollow11.South = deepHollow12;
            deepHollow11.West = deepHollow10;

            deepHollow12.North = deepHollow11;
            deepHollow12.East = deepHollow14;
            deepHollow12.South = deepHollow13;

            deepHollow13.North = deepHollow12;

            deepHollow14.East = deepHollow15;
            deepHollow14.West = deepHollow12;

            deepHollow15.South = deepHollow16;
            deepHollow15.West = deepHollow14;

            deepHollow16.North = deepHollow15;
            deepHollow16.West = deepHollow17;

            deepHollow17.East = deepHollow16;
            deepHollow17.South = deepHollow18;

            deepHollow18.North = deepHollow17;
            deepHollow18.South = deepHollow19;

            deepHollow19.North = deepHollow18;
            deepHollow19.East = deepHollow20;
            deepHollow19.South = hollowsHeart;

            deepHollow20.West = deepHollow19;

            wardenBridge.East = hollowsEdge13;
            wardenBridge.West = deepHollow1;

            hollowsHeart.North = deepHollow19;
        }

        private static void AssignRoomRequirements()
        {

        }

        private static void PopulateMap()
        {
            // add monsters to areas
            hollowsEdge.Monsters.Add(MonsterManager.hollowFiend);
            hollowsEdge.Monsters.Add(MonsterManager.hollowStalker);
            hollowsEdge.Monsters.Add(MonsterManager.corruptedWolf);
            abandonedVillage.Monsters.Add(MonsterManager.forsakenVillager);
            abandonedVillage.Monsters.Add(MonsterManager.cursedSpirit);
            whisperingGroves.Monsters.Add(MonsterManager.whisperingShadow);
            whisperingGroves.Monsters.Add(MonsterManager.forestGhoul);
        }
    }
}

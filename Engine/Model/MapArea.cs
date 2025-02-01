using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Model
{
    public class MapArea
    {
        public string Name { get; set; }
        public List<Monster> Monsters{ get; set; }
        public bool HasMonsters { get; set; }

        public MapArea(string name, bool hasMonsters)
        {
            Name = name;
            Monsters = new();
            HasMonsters = hasMonsters;
        }
    }
}

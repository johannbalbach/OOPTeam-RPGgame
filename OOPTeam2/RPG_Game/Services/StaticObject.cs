using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Services.Objects;

namespace OOPTeam2.RPG_Game.Services
{
    public class StaticObject
    {
        public List<Fence> fences {get; set;}
        public List<Stone> stones { get; set; }
        public List<Food> foods { get; set; }
    }
}
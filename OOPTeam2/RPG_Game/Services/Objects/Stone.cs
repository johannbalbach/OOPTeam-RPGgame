using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services.Objects
{
    public class Stone
    {
        public Position position { get; set; }
        public string drawID { get; private set; } = "Stone";
    }
}
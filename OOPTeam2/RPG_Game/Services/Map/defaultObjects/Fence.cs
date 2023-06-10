using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Ink;
using OOPTeam2.RPG_Game.Models.Characters;

namespace OOPTeam2.RPG_Game.Services.Objects
{
    public class Fence
    {
        public Position position { get; set; }
        public string drawID { get; private set; } = "Fence";

    }
}
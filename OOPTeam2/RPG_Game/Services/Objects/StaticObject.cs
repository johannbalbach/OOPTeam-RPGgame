using OOPTeam2.RPG_Game.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class StaticObject
    {
        public Position position { get; set; }
        public string drawID { get; protected set; }
    }
}

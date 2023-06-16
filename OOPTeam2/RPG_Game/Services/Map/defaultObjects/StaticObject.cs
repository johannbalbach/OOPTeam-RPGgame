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
        public Position Position { get; set; }
        public string DrawID { get; protected set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;

namespace OOPTeam2.RPG_Game.Services
{
    public class AliveObject
    {
/*      private List<Butterfly> butterflies;
        private List<Worm> worms;*/
        public List<GameCharacter> enemies { get; set; } = new List<GameCharacter>();
        public AliveObject() { }
    }
}
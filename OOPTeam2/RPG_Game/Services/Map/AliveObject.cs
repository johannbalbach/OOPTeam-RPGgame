using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

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
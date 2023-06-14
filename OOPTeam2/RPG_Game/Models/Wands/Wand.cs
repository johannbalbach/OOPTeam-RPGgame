using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Wands {
    public abstract class Wand {
        public int damage { set; get; }
        public double agility { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        public List<CharacterRace> possibleOwners { set; get; }
        
        public abstract int GetHarm(CharacterRace characterRace);
        public abstract void Drop();
        public abstract void Improve();
    }
}
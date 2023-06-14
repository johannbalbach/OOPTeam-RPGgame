using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public abstract class Sword {
        public double weight { set; get; }
        public double agility { set; get; }
        public double quality { set; get; }
        public int attack { set; get; }
        public bool isAvailable { set; get; }
        public List<CharacterRace> possibleOwners { set; get; }
        
        public abstract int ToDamage(CharacterRace characterRace);
        public abstract void Drop();
        public abstract void Improve();
        public abstract int CalculateDamage();
    }
}
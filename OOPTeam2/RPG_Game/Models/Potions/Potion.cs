using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public abstract class Potion {
        public int volume { set; get; }
        public int damage { set; get; }
        public string description { set; get; }
        public TypePotion typePotion { set; get; }
        public List<CharacterRace> possibleOwners { set; get; }
        
        public abstract void Reduce();
        public abstract bool IsEnoughVolume();
        public abstract int ToDamage(CharacterRace characterRace);
        public abstract void Drop();
        public abstract void Improve();
    }
}
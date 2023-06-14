using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public abstract class Potion {
        public int volume { set; get; }
        public int damage { set; get; }
        public string description { set; get; }
        public bool isAvailable { set; get; }
        public TypePotion typePotion { set; get; }
        protected List<CharacterRace> possibleOwners;
        
        public abstract int GetHurt(CharacterRace batterCharacterRace);
        public abstract void Increase();
        public abstract void Reduce();
    }
}
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models {
    public abstract class Weapon {
        public abstract void Hit(GameCharacter targetCharacter, CharacterRace raceAttackingCharacter);
        public abstract void Drop();
        public abstract int ToDamage(CharacterRace characterRace);
        public abstract void Improve();
    }
}
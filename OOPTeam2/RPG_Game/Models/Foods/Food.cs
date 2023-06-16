using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public abstract class Food {
        public int Power { get; set; }
        public abstract void Consume();
        public abstract bool IsEatable(CharacterRace characterRace);
        public abstract bool IsSufficientQuantity();
    }
}
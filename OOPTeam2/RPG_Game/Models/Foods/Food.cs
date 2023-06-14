using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public abstract class Food {
        public int power { get; set; }
        public abstract void Eat();
        public abstract bool IsEatable(CharacterRace characterRace);
        public abstract bool IsSufficientQuantity();
    }
}
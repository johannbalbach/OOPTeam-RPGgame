using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Bread: Food {
        public int Count { get; set; }

        public Bread(int count) {
            Count = count;
        }
        
        public Bread(int count, int power): this(count) {
            Power = power;
        }
        
        public override void Consume() {
            Count--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return (characterRace == CharacterRace.Wizard || characterRace == CharacterRace.Ork);
        }

        public override bool IsSufficientQuantity() {
            return Count > 0;
        }
    }
}
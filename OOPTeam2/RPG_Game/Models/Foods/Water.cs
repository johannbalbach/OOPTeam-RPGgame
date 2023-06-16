using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Water: Food {
        public int Volume { get; set; }

        public Water(int volume) {
            Volume = volume;
        }
        
        public Water(int volume, int power) : this(volume) {
            Power = power;
        }
        
        public override void Consume() {
            Volume--;
        }

        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Wizard || characterRace == CharacterRace.Human;
        }
        
        public override bool IsSufficientQuantity() {
            return Volume > 0;
        }
    }
}
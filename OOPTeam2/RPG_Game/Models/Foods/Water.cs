using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Water: Food {
        public int volume { get; set; }

        public Water(int volume) {
            this.volume = volume;
        }
        
        public Water(int volume, int power) {
            this.volume = volume;
            this.power = power;
        }
        
        public override void Consume() {
            volume--;
        }

        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Wizard || characterRace == CharacterRace.Human;
        }
        
        public override bool IsSufficientQuantity() {
            return volume > 0;
        }
    }
}

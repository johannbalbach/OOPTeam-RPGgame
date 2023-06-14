using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Flower: Food {
        public int beam { set; get; }

        public Flower(int beam) {
            this.beam = beam;
        }
        
        public override void Eat() {
            beam--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.ElvesCharacter || characterRace == CharacterRace.AlienCharacter;
        }
        
        public override bool IsSufficientQuantity() {
            return beam > 0;
        }
    }
}
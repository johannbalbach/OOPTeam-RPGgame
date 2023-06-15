using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Flower: Food {
        public int beam { set; get; }

        public Flower(int beam) {
            this.beam = beam;
        }

        public Flower(int beam, int power) {
            this.beam = beam;
            this.power = power;
        }
        
        public override void Consume() {
            beam--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Elf || characterRace == CharacterRace.Alien;
        }
        
        public override bool IsSufficientQuantity() {
            return beam > 0;
        }
    }
}
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Flower: Food {
        public int Beam { set; get; }

        public Flower(int beam) {
            Beam = beam;
        }

        public Flower(int beam, int power): this(beam) {
            Power = power;
        }
        
        public override void Consume() {
            Beam--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Elf || characterRace == CharacterRace.Alien;
        }
        
        public override bool IsSufficientQuantity() {
            return Beam > 0;
        }
    }
}
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Sausage: Food {
        private const double MIN_DOSE = 0.1;
        public double size { set; get; }

        public Sausage(double size) {
            this.size = size;
        }
        
        public Sausage(double size, int power) {
            this.size = size;
            this.power = power;
        }

        public override void Eat() { 
            size -= MIN_DOSE;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.GnomeCharacter || characterRace == CharacterRace.HumanCharacter;
        }
        
        public override bool IsSufficientQuantity() {
            return size >= MIN_DOSE;
        }
    }
}
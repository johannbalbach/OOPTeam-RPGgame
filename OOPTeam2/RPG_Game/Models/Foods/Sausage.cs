using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Sausage: Food {
        private const double MinDose = 0.1;
        public double size { set; get; }

        public Sausage(double size) {
            this.size = size;
        }
        
        public Sausage(double size, int power) : this(size) {
            this.power = power;
        }

        public override void Consume() { 
            size -= MinDose;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Gnome || characterRace == CharacterRace.Human;
        }
        
        public override bool IsSufficientQuantity() {
            return size >= MinDose;
        }
    }
}
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Sausage: Food {
        private const double MinDose = 0.1;
        public double Size { set; get; }

        public Sausage(double size) {
            Size = size;
        }
        
        public Sausage(double size, int power) : this(size) {
            Power = power;
        }

        public override void Consume() { 
            Size -= MinDose;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Gnome || characterRace == CharacterRace.Human;
        }
        
        public override bool IsSufficientQuantity() {
            return Size >= MinDose;
        }
    }
}
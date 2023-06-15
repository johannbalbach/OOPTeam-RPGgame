using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
public class Meat: Food {
        private const double MinDose = 0.1;
        public double Kilos { get; set; }

        public Meat(double kilos) {
            Kilos = kilos;
        }
        
        public Meat(double kilos, int power) : this (kilos) {
            Power = power;
        }

        public override void Consume() {
            Kilos -= MinDose;
        }

        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Alien || characterRace == CharacterRace.Human;
        }
        
        public override bool IsSufficientQuantity() {
            return Kilos >= MinDose;
        }
    }
}
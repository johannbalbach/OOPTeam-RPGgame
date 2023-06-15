using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
public class Meat: Food {
        private const double MinDose = 0.1;
        public double kilos { get; set; }

        public Meat(double kilos) {
            this.kilos = kilos;
        }
        
        public Meat(double kilos, int power) : this (kilos) {
            this.power = power;
        }

        public override void Consume() {
            kilos -= MinDose;
        }

        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Alien || characterRace == CharacterRace.Human;
        }
        
        public override bool IsSufficientQuantity() {
            return kilos >= MinDose;
        }
    }
}
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;


namespace OOPTeam2.RPG_Game.Models.Foods {
public class Meat: Food {
        private const double MIN_DOSE = 0.1;
        public double kilos { get; set; }

        public Meat(double kilos) {
            this.kilos = kilos;
        }

        public override void Eat() {
            kilos -= MIN_DOSE;
        }

        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.AlienCharacter || characterRace == CharacterRace.HumanCharacter;
        }
        
        public override bool IsSufficientQuantity() {
            return kilos >= MIN_DOSE;
        }
    }
}
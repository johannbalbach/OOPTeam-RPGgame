using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Bread: Food {
        public int count { get; set; }

        public Bread(int count) {
            this.count = count;
        }
        
        public Bread(int count, int power) {
            this.count = count;
            this.power = power;
        }
        
        public override void Consume() {
            count--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return (characterRace == CharacterRace.Wizard || characterRace == CharacterRace.Ork);
        }

        public override bool IsSufficientQuantity() {
            return count > 0;
        }
    }
}
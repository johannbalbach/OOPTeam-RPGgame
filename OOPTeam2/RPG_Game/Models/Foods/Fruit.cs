using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Fruit: Food{
        public int count { set; get; }

        public Fruit(int count) {
            this.count = count;
        }
        
        public Fruit(int count, int power) {
            this.count = count;
            this.power = power;
        }
        
        public override void Consume() {
            count--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Gnome;
        }
        
        public override bool IsSufficientQuantity() {
            return count > 0;
        }
    }
}
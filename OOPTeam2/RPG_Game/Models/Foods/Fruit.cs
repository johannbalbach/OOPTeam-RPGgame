using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Fruit: Food {
        public int Count { set; get; }

        public Fruit(int count) { 
            Count = count;
        }
        
        public Fruit(int count, int power) : this(count) {
            Power = power;
        }
        
        public override void Consume() {
            Count--;
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Gnome;
        }
        
        public override bool IsSufficientQuantity() {
            return Count > 0;
        }
    }
}
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Butter: Food {
        public int Volume { set; get; }

        public Butter(int volume) {
            Volume = volume;
        }
        
        public Butter(int volume, int power) : this(volume) {
            Power = power;
        }
        
        public override void Consume() {
            Volume--;    
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Elf || characterRace == CharacterRace.Gnome;
        }
        
        public override bool IsSufficientQuantity() {
            return Volume > 0;
        }
    }
}
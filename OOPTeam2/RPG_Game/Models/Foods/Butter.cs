using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Butter: Food {
        public int volume { set; get; }

        public Butter(int volume) {
            this.volume = volume;
        }
        
        public Butter(int volume, int power) : this(volume) {
            this.power = power;
        }
        
        public override void Consume() {
            volume--;    
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.Elf || characterRace == CharacterRace.Gnome;
        }
        
        public override bool IsSufficientQuantity() {
            return volume > 0;
        }
    }
}
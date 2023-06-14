using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;

namespace OOPTeam2.RPG_Game.Models.Foods {
    public class Fruit: Food{
        public int count { set; get; }

        public Fruit(int count) {
            this.count = count;
        }
        
        public override void Eat() {
            if (count > 0) {
                count--;
            }
        }
        
        public override bool IsEatable(CharacterRace characterRace) {
            return characterRace == CharacterRace.GnomeCharacter;
        }
    }
}
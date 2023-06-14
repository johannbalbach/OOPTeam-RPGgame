using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GnomeCharacter: GameCharacter {
        private const CharacterRace gnome = CharacterRace.GnomeCharacter;
        private CharacterReply text = new CharacterReply(TextEnum.GnomesText);
        
        public override string Talk() {
            return text.GetText();
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(gnome)) {
                food.Eat();
            }
        }
    }
}
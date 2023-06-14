using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class GnomeCharacter: GameCharacter {
        
        public GnomeCharacter() {
            characterRace = CharacterRace.GnomeCharacter;
            text = new CharacterReply(TextEnum.GnomesText);
        }
        
        public override string Talk() {
            return text.GetText();
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(characterRace) && food.IsSufficientQuantity()) {
                food.Eat();
            }
        }
    }
}
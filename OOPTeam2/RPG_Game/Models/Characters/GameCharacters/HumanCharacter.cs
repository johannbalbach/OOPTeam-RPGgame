using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class HumanCharacter: GameCharacter {

        public HumanCharacter() {
            characterRace = CharacterRace.Human;
            text = new CharacterReply(TextEnum.HumansText);
        }
        
        public override string Talk() {
            return text.GetText();
        }

        public override void Eat(Food food) {
            if (food.IsEatable(characterRace) && food.IsSufficientQuantity()) {
                food.Consume();
            }
        }
    }
}
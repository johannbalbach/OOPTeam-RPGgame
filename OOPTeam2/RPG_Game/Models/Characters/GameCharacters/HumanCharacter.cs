using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class HumanCharacter: GameCharacter {

        public HumanCharacter() {
            CharacterRace = CharacterRace.Human;
            Text = new CharacterReply(TextEnum.HumansText);
        }
        
        public override string Talk() {
            return Text.GetText();
        }

        public override void Eat(Food food) {
            if (food.IsEatable(CharacterRace) && food.IsSufficientQuantity()) {
                food.Consume();
            }
        }
    }
}
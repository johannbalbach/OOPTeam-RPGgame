using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class WizardCharacter: GameCharacter { 
        
        public WizardCharacter() {
            Text = new CharacterReply(TextEnum.WizardsText);
            CharacterRace = CharacterRace.Wizard;
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
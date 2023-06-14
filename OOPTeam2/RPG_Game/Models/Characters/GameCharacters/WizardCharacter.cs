using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class WizardCharacter: GameCharacter { 
        
        public WizardCharacter() {
            text = new CharacterReply(TextEnum.WizardsText);
            characterRace = CharacterRace.WizardCharacter;
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
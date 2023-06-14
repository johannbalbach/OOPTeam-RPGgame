using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class WizardCharacter: GameCharacter { 
        private const CharacterRace wizard = CharacterRace.WizardCharacter;
        private CharacterReply text = new CharacterReply(TextEnum.WizardsText);
        
        public override string Talk() {
            return text.GetText();
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(wizard)) {
                food.Eat();
            }
        }
    }
}
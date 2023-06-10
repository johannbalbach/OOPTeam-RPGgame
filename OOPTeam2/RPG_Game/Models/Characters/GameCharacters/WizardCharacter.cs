namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class WizardCharacter: GameCharacter { 
        private CharacterReply text = new CharacterReply(TextEnum.WizardsText);
        public override string Talk() {
            return text.GetText();
        }
    }
}
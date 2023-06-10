namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class CnomeCharacter: GameCharacter {
        private CharacterReply text = new CharacterReply(TextEnum.GnomesText);
        public override string Talk() {
            return text.GetText();
        }
    }
}
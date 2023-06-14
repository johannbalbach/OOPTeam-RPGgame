namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Worm: NonPlayerCharacter {
        
        public Worm() {
            text = new CharacterReply();
        }
        
        public override string Talk() {
            return text.GetText();
        }
    }
}
namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Worm: NonPlayerCharacter {
        
        public Worm() {
            Text = new CharacterReply();
        }
        
        public override string Talk() {
            return Text.GetText();
        }
    }
}
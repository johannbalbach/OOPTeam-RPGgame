namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Butterfly: NonPlayerCharacter {
        
        public Butterfly() {
            Text = new CharacterReply();
        }
        
        public override string Talk() {
            return Text.GetText();
        }
    }
}
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Butterfly: NonPlayerCharacter {
        
        public Butterfly() {
            text = new CharacterReply();
        }
        
        public override string Talk() {
            return text.GetText();
        }
    }
}
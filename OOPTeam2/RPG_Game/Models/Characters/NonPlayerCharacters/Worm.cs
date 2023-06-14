namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Worm: NonPlayerCharacter {
        
        public Worm() {
            text = new CharacterReply(TextEnum.AvatarText);
        }
        
        public override string Talk() {
            return text.GetText();
        }
    }
}
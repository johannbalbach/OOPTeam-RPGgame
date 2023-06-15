namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Avatar: NonPlayerCharacter {
        
        public Avatar() {
            lifePoint = int.MaxValue;
            text = new CharacterReply(TextEnum.AvatarText);
        }
        
        public override string Talk() {
            return text.GetText();
        }

        public void RestoreHealth() {
            lifePoint = int.MaxValue;
        }
    }
}

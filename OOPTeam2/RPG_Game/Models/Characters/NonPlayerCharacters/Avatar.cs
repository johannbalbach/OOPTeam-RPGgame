namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Avatar: NonPlayerCharacter {
        
        public Avatar(string skinId) : this() {
            SkinId = skinId;
        }

        public Avatar() {
            LifePoint = int.MaxValue;
            Text = new CharacterReply(TextEnum.AvatarText);
        }
        
        
        public override string Talk() {
            return Text.GetText();
        }

        public void RestoreHealth() {
            LifePoint = int.MaxValue;
        }
    }
}
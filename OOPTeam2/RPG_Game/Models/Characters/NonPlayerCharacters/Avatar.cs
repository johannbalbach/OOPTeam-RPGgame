using System;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Avatar: NonPlayerCharacter {
        private SingletonRand random { set; get; }

        public Avatar() {
            lifePoint = Int32.MaxValue;
            random = SingletonRand.GetInstance();
            text = new CharacterReply(TextEnum.AvatarText);
        }
        
        public override string Talk() {
            return text.GetText();
        }

        public void RestoreHealth() {
            lifePoint = Int32.MaxValue;
        }
    }
}

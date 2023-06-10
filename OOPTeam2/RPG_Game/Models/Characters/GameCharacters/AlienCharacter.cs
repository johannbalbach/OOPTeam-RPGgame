using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class AlienCharacter : GameCharacter {
        private const int TIME_SLEEP = 500;
        private CharacterReply text = new CharacterReply(TextEnum.AliensText);
        public override string Talk() {
            return text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }

    }
}
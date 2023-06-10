using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class ElvesCharacter: GameCharacter {
        private const int TIME_SLEEP = 5000;
        private CharacterReply text = new CharacterReply(TextEnum.ElvesText);
        
        public override string Talk() {
            return text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }
    }
}
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class ElvesCharacter: GameCharacter {
        private const int TIME_SLEEP = 5000;
        
        public override string Talk() {
            return
                "Our connection with nature runs deep. We are guardians of the forests, preserving the beauty and harmony of the natural world.";
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }
    }
}
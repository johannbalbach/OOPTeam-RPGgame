using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class AlienCharacter : GameCharacter {
        private const int TIME_SLEEP = 500;
        public override string Talk() {
            return
                "Greetings, Earthlings! We come in peace from a distant galaxy, seeking to understand and connect with different civilizations.";
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }

    }
}
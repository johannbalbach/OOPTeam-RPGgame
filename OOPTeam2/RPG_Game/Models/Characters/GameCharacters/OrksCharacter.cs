using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class OrksCharacter: GameCharacter {
        private CharacterReply text = new CharacterReply(TextEnum.OrksText);
        private const int TIME_SLEEP = 7000;
        public override string Talk() {
            return text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }
        
        public override void Eat(Food food) {
            if (food is Bread || food is Butter) {
                return;
            }
            food.Eat();
        }
    }
}
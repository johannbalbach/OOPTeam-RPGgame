using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class OrksCharacter: GameCharacter {
        private const int TIME_SLEEP = 7000;
        public override string Talk() {
            return "Me crush puny humans! Orcs strong! Orcs conquer all!";
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
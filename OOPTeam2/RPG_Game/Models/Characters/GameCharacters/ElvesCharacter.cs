using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class ElvesCharacter: GameCharacter {
        private const CharacterRace elves = CharacterRace.ElvesCharacter;
        private const int TIME_SLEEP = 5000;
        private CharacterReply text = new CharacterReply(TextEnum.ElvesText);
        
        public override string Talk() {
            return text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(elves)) {
                food.Eat();
            }
        }
    }
}

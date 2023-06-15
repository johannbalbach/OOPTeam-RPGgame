using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class OrksCharacter: GameCharacter {
        private const int SleepTimeMilliseconds = 7000;

        public OrksCharacter() {
            characterRace = CharacterRace.Ork;
            text = new CharacterReply(TextEnum.OrksText);
        }
        public override string Talk() {
            return text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(SleepTimeMilliseconds);
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(characterRace) && food.IsSufficientQuantity()) {
                food.Consume();
            }
        }
    }
}
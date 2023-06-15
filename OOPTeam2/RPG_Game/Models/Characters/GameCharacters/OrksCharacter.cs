using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class OrksCharacter: GameCharacter {
        private const int SleepTimeMilliseconds = 7000;

        public OrksCharacter() {
            CharacterRace = CharacterRace.Ork;
            Text = new CharacterReply(TextEnum.OrksText);
        }
        public override string Talk() {
            return Text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(SleepTimeMilliseconds);
        }
        
        public override void Eat(Food food) {
            if (food.IsEatable(CharacterRace) && food.IsSufficientQuantity()) {
                food.Consume();
            }
        }
    }
}
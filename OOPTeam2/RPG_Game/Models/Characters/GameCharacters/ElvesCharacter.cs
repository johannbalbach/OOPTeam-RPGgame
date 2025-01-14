using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class ElvesCharacter: GameCharacter {
        private const int SleepTimeMilliseconds = 3500;

        public ElvesCharacter() {
            CharacterRace = CharacterRace.Elf;
            Text = new CharacterReply(TextEnum.ElvesText);
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
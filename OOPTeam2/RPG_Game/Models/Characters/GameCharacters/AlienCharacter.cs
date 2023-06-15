using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class AlienCharacter : GameCharacter {
        private const int SleepTimeMilliseconds = 500;

        public AlienCharacter() {
            characterRace = CharacterRace.Alien;
            text = new CharacterReply(TextEnum.AliensText);
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
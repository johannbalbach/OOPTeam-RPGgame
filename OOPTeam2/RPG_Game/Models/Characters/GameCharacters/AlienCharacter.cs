using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class AlienCharacter : GameCharacter {
        private const int TIME_SLEEP = 500;

        public AlienCharacter() {
            characterRace = CharacterRace.AlienCharacter;
            text = new CharacterReply(TextEnum.AliensText);
        }
        
        public override string Talk() {
            return text.GetText();
        }
        
        public override async void Sleep() {
            await Task.Delay(TIME_SLEEP);
        }

        public override void Eat(Food food) {
            if (food.IsEatable(characterRace) && food.IsSufficientQuantity()) {
                food.Eat();
            }
        }
    }
}
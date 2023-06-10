using System;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class HumanCharacter: GameCharacter {
        private CharacterReply text = new CharacterReply(TextEnum.HumansText);
        
        public override string Talk() {
            return text.GetText();
        }

        public override void Eat(Food food) {
            if (food is Flower) {
                return;
            }
            food.Eat();
        }

    }
}
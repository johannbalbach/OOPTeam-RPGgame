using System;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class HumanCharacter: GameCharacter {
        public override string Talk() {
            return
                "We strive for knowledge and progress, exploring the wonders of the world and creating a better future for all.";
        }

        public override void Eat(Food food) {
            if (food is Flower) {
                return;
            }
            food.Eat();
        }

    }
}
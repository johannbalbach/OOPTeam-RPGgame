using System;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class OrksCharacter: GameCharacter {
        public OrksCharacter() {
            throw new System.NotImplementedException();
        }
        
        public override void Move(Position position, string direction) {
            throw new System.NotImplementedException();
        }
        
        public override void Hit() {
            throw new System.NotImplementedException();
        }
        
        public override string Talk() {
            return "Me crush puny humans! Orcs strong! Orcs conquer all!";
        }
        
        public override void Sleep() {
            throw new System.NotImplementedException();
        }
        
        public override void Eat(Food food) {
            throw new System.NotImplementedException();
        }

        public override void GetApperance() {
            throw new System.NotImplementedException();
        }
    }
}
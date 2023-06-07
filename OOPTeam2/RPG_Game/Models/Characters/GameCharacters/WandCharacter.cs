using System;
using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class WandCharacter: GameCharacter {
        
        public WandCharacter() {
            throw new System.NotImplementedException();
        }
        
        public override void Move(Position position, string direction) {
            throw new System.NotImplementedException();
        }
        
        public override void Hit() {
            throw new System.NotImplementedException();
        }
        
        public override string Talk() {
            return "I harness the arcane forces to bend reality to my will. Magic flows through my veins like a river of power.";
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
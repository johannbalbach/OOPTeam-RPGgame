using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class CnomeCharacter: GameCharacter {
        public CnomeCharacter() {
            throw new System.NotImplementedException();
        }
        
        public override void Move(Position position, string direction) {
            throw new System.NotImplementedException();
        }
        
        public override void Hit() {
            throw new System.NotImplementedException();
        }
        
        public override string Talk() {
            return
                "Inventions and innovation are our passion! We tinker and create, finding ingenious solutions to every problem.";
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
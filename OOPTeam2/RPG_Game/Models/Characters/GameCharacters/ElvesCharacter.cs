using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class ElvesCharacter: GameCharacter {
        public ElvesCharacter() {
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
                "Our connection with nature runs deep. We are guardians of the forests, preserving the beauty and harmony of the natural world.";
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
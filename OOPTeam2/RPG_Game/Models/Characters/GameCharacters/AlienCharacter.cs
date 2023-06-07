using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.GameCharacters {
    public class AlienCharacter : GameCharacter {
        
        public AlienCharacter() {
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
                "Greetings, Earthlings! We come in peace from a distant galaxy, seeking to understand and connect with different civilizations.";
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
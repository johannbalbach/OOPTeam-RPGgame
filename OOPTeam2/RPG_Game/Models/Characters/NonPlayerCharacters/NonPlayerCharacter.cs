using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        protected bool isAlive { get; set; }
        
        public override void Move(Position position, string direction) {
            throw new System.NotImplementedException();
        }

        public override void Hit() {
            throw new System.NotImplementedException();
        }

        public override string Talk() {
            throw new System.NotImplementedException();
        }

        public override void Sleep() {
            throw new System.NotImplementedException();
        }

        public override void Eat(Food food) {
            throw new System.NotImplementedException();
        }

        public virtual void GetApperance() {
            throw new System.NotImplementedException();
        }
    }
}
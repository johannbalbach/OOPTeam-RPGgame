namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        protected bool isAlive { get; set; }
        
        public override void Move() {
            throw new System.NotImplementedException();
        }

        public override void Hit() {
            throw new System.NotImplementedException();
        }

        public override void Talk() {
            throw new System.NotImplementedException();
        }

        public override void Sleep() {
            throw new System.NotImplementedException();
        }

        public override void Eat() {
            throw new System.NotImplementedException();
        }

        public override void ChangeWeapon() {
            throw new System.NotImplementedException();
        }
        
        public virtual void GetApperance() {
            throw new System.NotImplementedException();
        }
    }
}
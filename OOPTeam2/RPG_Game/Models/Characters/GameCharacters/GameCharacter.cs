namespace OOPTeam2.RPG_Game.Models.Characters {
    public class GameCharacter: Character {
        public int playTime { get; set; }
        public Inventory inventory { get; set; }
        public bool isEnemy { get; set; }
        public bool isAlive { get; set; }
        public double speed { get; set; }
        
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
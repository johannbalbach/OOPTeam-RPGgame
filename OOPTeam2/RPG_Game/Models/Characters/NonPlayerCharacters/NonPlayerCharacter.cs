using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        
        public NonPlayerCharacter() {
            
        }
        
        public NonPlayerCharacter(NonPlayerCharacter target) {
            if (target != null) {
                isAlive = target.isAlive;
                healthRegeneration = target.healthRegeneration;
                age = target.age;
                name = target.name;
                position = target.position;
            }
        }
        
        public override void Move(Position position, Direction direction) {
            
        }
        
        public override Character Clone() {
            return new NonPlayerCharacter(this);
        }

        public override void Hit(Potion potion) {
            throw new System.NotImplementedException();
        }
        
        public override void Hit(Sword sword) {
            throw new System.NotImplementedException();
        }
        
        public override void Hit(Wand wand) {
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
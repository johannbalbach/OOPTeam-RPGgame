using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        
        public NonPlayerCharacter() {
            lifePoint = INIT_HEALTH;
            text = new CharacterReply();
        }
        
        public NonPlayerCharacter(NonPlayerCharacter target) {
            if (target != null) {
                age = target.age;
                name = target.name;
                position = target.position;
                text = new CharacterReply();
            }
        }
        
        public override void Move(Position position, Direction direction) {
            Step(position, direction);
        }
        
        public override Character Clone() {
            return new NonPlayerCharacter(this);
        }

        public override string Talk() {
            return text.GetText();
        }

        public override void Sleep() {
            // NPC не должен спать, поэтому метод Sleep остается пустым
        }

        public override void Eat(Food food) {
            // NPC не кушает еду, поэтому метод Eat остается пустым
        }
    }
}
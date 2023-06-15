using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        
        public NonPlayerCharacter() {
            lifePoint = InitialHealth;
            text = new CharacterReply();
        }
        
        public NonPlayerCharacter(NonPlayerCharacter source) : this () {
            if (source != null) {
                age = source.age;
                name = source.name;
                position = source.position;
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
            // NPCs don't sleep, so the Sleep method remains empty.
        }

        public override void Eat(Food food) {
            // NPCs don't eat food, so the Eat method remains empty.
        }
    }
}
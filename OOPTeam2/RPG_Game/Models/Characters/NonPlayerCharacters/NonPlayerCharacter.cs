using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        
        public NonPlayerCharacter() {
            LifePoint = InitialHealth;
            Text = new CharacterReply();
        }
        
        public NonPlayerCharacter(NonPlayerCharacter source) : this () {
            if (source != null) {
                Age = source.Age;
                Name = source.Name;
                Position = source.Position;
            }
        }

        public override Character Clone() {
            return new NonPlayerCharacter(this);
        }

        public override string Talk() {
            return Text.GetText();
        }

        public override void Sleep() {
            // NPCs don't sleep, so the Sleep method remains empty.
        }

        public override void Eat(Food food) {
            // NPCs don't eat food, so the Eat method remains empty.
        }
    }
}
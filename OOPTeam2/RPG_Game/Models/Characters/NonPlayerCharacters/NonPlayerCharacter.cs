using System.Threading.Tasks;
using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters{
    public class NonPlayerCharacter: Character {
        private const int FREEZING_TIME = 5000;
        
        public NonPlayerCharacter() {
            lifePoint = INIT_HEALTH;
        }
        
        public NonPlayerCharacter(NonPlayerCharacter target) {
            if (target != null) {
                age = target.age;
                name = target.name;
                position = target.position;
            }
        }
        
        public override void Move(Position position, Direction direction) {
            Step(position, direction);
        }
        
        public override Character Clone() {
            return new NonPlayerCharacter(this);
        }

        public override bool Hit(Potion potion) {
            lifePoint = 0;
            return true;
        }
        
        public override bool Hit(Sword sword) {
            lifePoint -= sword.GetDamage();
            return true;
        }
        
        public override bool Hit(Wand wand) {
            lifePoint = 0;
            return true;
        }

        public override string Talk() {
            return "Hello, player!";
        }

        public override void Sleep() {
            // NPC не должен спать, поэтому метод Sleep остается пустым
        }

        public override void Eat(Food food) {
            // у NPC не растёт lifePoint за счёт еды
            food.Eat();
        }
    }
}
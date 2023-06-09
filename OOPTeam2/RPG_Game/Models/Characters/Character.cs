using System.Dynamic;
using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters {
    public abstract class Character {
        public string name { get; set; }
        public Position position { get; set; }
        public int age { get; set; }
        public int lifePoint { get; set; }
        /*protected const int HEALTH_REGENERATION = 1;*/
        protected const int INIT_HEALTH = 100;

        public abstract void Move(Position position, Direction direction);
        public abstract void Hit(Potion potion);
        public abstract void Hit(Sword sword);
        public abstract void Hit(Wand wand);
        public abstract string Talk();
        public abstract void Sleep();
        public abstract void Eat(Food food);
        public abstract Character Clone();
        
        protected void Step(Position position, Direction direction) {
            switch (direction) {
                case Direction.Left:
                    position.x -= 1;
                    break;
                case Direction.Right:
                    position.x += 1;
                    break;
                case Direction.Top:
                    position.y += 1;
                    break;
                case Direction.Down:
                    position.y -= 1;
                    break;
            }
        }
    }
}
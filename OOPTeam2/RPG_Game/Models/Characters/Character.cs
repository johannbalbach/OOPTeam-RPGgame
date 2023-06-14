using System.Dynamic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
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
        public CharacterReply text { get; set; }
        
        protected const int INIT_HEALTH = 100;

        public abstract void Move(Position position, Direction direction);
        public abstract bool Hit(Potion potion);
        public abstract bool Hit(Sword sword, CharacterRace characterRace);
        public abstract bool Hit(Wand wand, CharacterRace characterRace);
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
        
        protected void NormalizeLifePoint() {
            if (lifePoint > INIT_HEALTH) {
                lifePoint = INIT_HEALTH;
            } else if (lifePoint < 0) {
                lifePoint = 0;
            }
        }
    }
}
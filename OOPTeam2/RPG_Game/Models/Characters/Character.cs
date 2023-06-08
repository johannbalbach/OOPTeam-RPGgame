using OOPTeam2.RPG_Game.Models.Foods;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;

namespace OOPTeam2.RPG_Game.Models.Characters {
    public abstract class Character {
        public bool isAlive { get; set; }
        public string name { get; set; }
        public Position position { get; set; }
        public int age { get; set; }
        public int lifePoint { get; set; }
        public int healthRegeneration { get; set; }

        public abstract void Move(Position position, Direction direction);
        public abstract void Hit(Potion potion);
        public abstract void Hit(Sword sword);
        public abstract void Hit(Wand wand);
        public abstract string Talk();
        public abstract void Sleep();
        public abstract void Eat(Food food);
        public abstract Character Clone();
    }
}
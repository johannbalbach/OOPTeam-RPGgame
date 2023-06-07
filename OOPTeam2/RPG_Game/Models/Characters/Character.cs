using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters {
    public abstract class Character {
        protected string name { get; set; }
        protected Position position { get; set; }
        protected int age { get; set; }
        protected string gender { get; set; }
        protected int lifePoint { get; set; }
        protected string skin { get; set; }
        protected double protectionBonus { get; set; }
        protected int size { get; set; }

        public abstract void Move(Position position, string direction);
        public abstract void Hit();
        public abstract string Talk();
        public abstract void Sleep();
        public abstract void Eat(Food food);
    }
}
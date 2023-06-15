using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters {
    public abstract class Character {
        public string name { get; set; }
        public Position position { get; set; }
        public int age { get; set; }
        public int lifePoint { get; set; }
        public CharacterReply text { get; set; }
        
        protected const int InitialHealth = 100;

        public abstract void Move(Position position, Direction direction);
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
            if (lifePoint > InitialHealth) {
                lifePoint = InitialHealth;
            } else if (lifePoint < 0) {
                lifePoint = 0;
            }
        }
    }
}
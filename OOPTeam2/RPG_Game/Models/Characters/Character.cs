using OOPTeam2.RPG_Game.Models.Foods;

namespace OOPTeam2.RPG_Game.Models.Characters {
    public abstract class Character {
        public string Name { get; set; }
        public Position Position { get; set; }
        public int Age { get; set; }
        public int LifePoint { get; set; }
        public string SkinId { get; set; }
        public CharacterReply Text { get; set; }
        
        protected const int InitialHealth = 100;
        public abstract string Talk();
        public abstract void Sleep();
        public abstract void Eat(Food food);
        public abstract Character Clone();
        
        protected void Step(Position currentPosition, Direction direction) {
            switch (direction) {
                case Direction.Left:
                    currentPosition.X -= 1;
                    break;
                case Direction.Right:
                    currentPosition.X += 1;
                    break;
                case Direction.Top:
                    currentPosition.Y += 1;
                    break;
                case Direction.Down:
                    currentPosition.Y -= 1;
                    break;
            }
        }
        
        public void Move(Position newPosition, Direction direction) {
            Step(newPosition, direction);
        }
        
        public void NormalizeLifePoint() {
            if (LifePoint > InitialHealth) {
                LifePoint = InitialHealth;
            } else if (LifePoint < 0) {
                LifePoint = 0;
            }
        }
    }
}
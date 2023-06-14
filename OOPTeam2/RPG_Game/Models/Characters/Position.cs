using System;

namespace OOPTeam2.RPG_Game.Models.Characters {
    public class Position {
        public int x { get; set; }
        public int y { get; set; }
        
        public Position(int x, int y) {
            this.x = x;
            this.y = y;
        }
        
        public void ChangePosition(Position position) {
            x = position.x;
            y = position.y;
        }
        
        public double GetDistance(Position position) {
            return Math.Sqrt((x - position.x) * (x - position.x) + (y - position.y) * (y - position.y));
        }
        
    }
}
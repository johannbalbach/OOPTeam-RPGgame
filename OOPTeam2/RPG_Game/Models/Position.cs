using System;

namespace OOPTeam2.RPG_Game.Models {
    public class Position {
        public int X { get; set; }
        public int Y { get; set; }
        
        public Position(int x, int y) {
            X = x;
            Y = y;
        }
        
        public void ChangePosition(Position newPosition) {
            X = newPosition.X;
            Y = newPosition.Y;
        }
        
        public double GetDistance(Position position) {
            return Math.Sqrt((X - position.X) * (X - position.X) + (Y - position.Y) * (Y - position.Y));
        }
    }
}
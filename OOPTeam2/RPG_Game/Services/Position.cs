using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services
{
    public class Position
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void SetTwoPoint(int x, int y)
        {
            if ((x < 1 && x >2000) || (y < 1 && y > 2000))///границы поля
            {
                throw new ArgumentException("Point must be in range 1 - 2000");//
            }
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj) => this.Equals(obj as Position);

        public bool Equals(Position p)
        {
            if (p is null)
            {
                return false;
            }

            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            if (this.GetType() != p.GetType())
            {
                return false;
            }

            return (X == p.X) && (Y == p.Y);
        }
        public void Step(string direction){
            switch(direction){
                case "left":
                    this.X = X-1;
                    this.Y = Y;
                    break;
                case "right":
                    this.X = X+1;
                    this.Y = Y;
                    break;
                case "top":
                    this.X = X;
                    this.Y = Y+1;
                    break;
                case "down":
                    this.X = X;
                    this.Y = Y-1;
                    break;
            }
        }
    }
}
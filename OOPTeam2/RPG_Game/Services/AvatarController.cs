using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOPTeam2.RPG_Game.Services
{
    public class AvatarController
    {
        public GameCharacter avatar { get; private set; }
        private double angle = 45;
        private int k = 1;

        public AvatarController(ref GameCharacter avatar)
        {
            this.avatar = avatar;
        }
        public void Update(GameCharacter player)
        {
            avatar.position = NextPosition(player.position);
            Console.WriteLine("avatar x position is: " + avatar.position.X + "  avatar y position is: " + avatar.position.Y);
        }
        private double Distance(Position a, Position b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
        private Position NextPosition(Position playerPosition)
        {
            //double distance = Distance(playerPosition, avatar.position);
            double radius = 70;
            if (angle > 135)
            {
                k = k * (-1);
                angle += k;
            }
            else if (angle < 45)
            {
                k = k * (-1);
                angle += k;
            }
            else
                angle += k;
   
            //double angle = Math.Atan2(playerPosition.Y - avatar.position.Y, playerPosition.X - avatar.position.X);

            double x = playerPosition.X + (radius * Math.Cos(angle + Math.PI / 4));
            double y = playerPosition.Y + (radius * Math.Sin(angle + Math.PI / 4));

            return new Position(((int)x), ((int)y));
        }

    }
}

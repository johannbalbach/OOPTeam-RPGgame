using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;

namespace OOPTeam2.RPG_Game.Services
{
    public class AvatarController
    {
        public Avatar avatar { get; private set; }
        private int angle = 0;
        private int k = 1;

        public AvatarController(ref Avatar avatar)
        {
            this.avatar = avatar;
        }
        public void Update(GameCharacter player)
        {
            avatar.position = NextPosition(player.position);
        }
        public void Onclick(GameCharacter player)
        {
            player.lifePoint = 100;///INIT_HEALTH
        }
        private double Distance(Position a, Position b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));  
        }
        private Position NextPosition(Position playerPosition)
        {
            /*double radius = Distance(playerPosition, avatar.position);
            double angle = Math.Atan2(playerPosition.y - avatar.position.y, playerPosition.x - avatar.position.x);*/

            /*            if (angle > 135)
            {
                Console.WriteLine("1" + angle);
                k = k * (-1);
                angle += k;
            }
            else if (angle < 45)
            {
                Console.WriteLine("2"+ angle);
                k = k * (-1);
                angle += k;
            }
            else
            {
                Console.WriteLine("3" + angle);
                angle += k;
            }*/

            double radius = config.avatarDistance;
            angle++;

            double x = playerPosition.x + (radius * Math.Cos(angle));
            double y = playerPosition.y + (radius * Math.Sin(angle));

            return new Position(((int)x), ((int)y));
        }
        private void Onclick() { }
    }
}

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
        private double angle = 45;
        private int k = 1;

        public AvatarController(ref Avatar avatar)
        {
            this.avatar = avatar;
        }
        public void Update(GameCharacter player)
        {
            avatar.position = NextPosition(player.position);
        }
        private double Distance(Position a, Position b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));  
        }
        private Position NextPosition(Position playerPosition)
        {
            //double distance = Distance(playerPosition, avatar.position);
            double radius = config.avatarDistance;
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

            double x = playerPosition.x + (radius * Math.Cos(angle + Math.PI / 4));
            double y = playerPosition.y + (radius * Math.Sin(angle + Math.PI / 4));

            return new Position(((int)x), ((int)y));
        }
        private void Onclick() { }
    }
}

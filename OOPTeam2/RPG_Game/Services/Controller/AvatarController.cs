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
        private const int healChance = 3;
        private const int chanceMax = 10;

        public AvatarController(ref Avatar avatar)
        {
            this.avatar = avatar;
        }
        public void Update(GameCharacter player)
        {
            avatar.position = NextPosition(player.position);
        }
        public void OnBottom(GameCharacter player)
        {
            SingletonRand rnd = SingletonRand.getInstance();

            if (rnd.Next(chanceMax) <= healChance)
            {
                player.lifePoint = 100;//INIT_HEALTH
            }
            avatar.position = NextPosition(player.position);
        }
        private double Distance(Position a, Position b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));  
        }

        private Position NextPosition(Position playerPosition)
        {
            double radius = config.avatarDistance;
            angle++;

            double x = playerPosition.x + (radius * Math.Cos(angle*180/Math.PI));
            double y = playerPosition.y + (radius * Math.Sin(angle*180/Math.PI));

            return new Position(((int)x), ((int)y));
        }
    }
}

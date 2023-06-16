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
            avatar.Position = NextPosition(player.Position);
        }
        public void OnBottom(GameCharacter player)
        {
            SingletonRand rnd = SingletonRand.GetInstance();

            if (rnd.Next(chanceMax) <= healChance)
            {
                player.LifePoint = 100;//INIT_HEALTH
            }
            avatar.Position = NextPosition(player.Position);
        }
        private double Distance(Position a, Position b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));  
        }

        private Position NextPosition(Position playerPosition)
        {
            double radius = config.avatarDistance;
            angle++;

            double x = playerPosition.X + (radius * Math.Cos(angle*180/Math.PI));
            double y = playerPosition.Y + (radius * Math.Sin(angle*180/Math.PI));

            return new Position(((int)x), ((int)y));
        }
    }
}

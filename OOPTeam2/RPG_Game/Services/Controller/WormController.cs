using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;

namespace OOPTeam2.RPG_Game.Services.Controller
{
    public class WormController: BackgroundCharacterController
    {
        public Worm worm { get; protected set; }

        private int EarthLevel = -10;
        public WormController(Worm worm)
        {
            this.worm = worm;
        }

        protected override void turnLeft()
        {
            if (currentIndex != 0 && worm.Position.Y < EarthLevel) //проверка на уровень земли
            {
                --currentIndex;
            }
            else
            {
                currentIndex = 7;
            }
        }
        protected override void turnRight()
        {
            if (currentIndex != 7 && worm.Position.Y < EarthLevel) //проверка на уровень земли
            {
                ++currentIndex;
            }
            else
            {
                currentIndex = 0;
            }
        }
    }
}

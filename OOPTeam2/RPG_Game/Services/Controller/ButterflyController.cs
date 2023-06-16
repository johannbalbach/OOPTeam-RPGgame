using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;

namespace OOPTeam2.RPG_Game.Services.Controller
{
    public class ButterflyController: BackgroundCharacterController
    {
        public Butterfly butterfly { get; protected set; }

        private int EarthLevel = 10;

        public ButterflyController(Butterfly butterfly)
        {
            this.butterfly = butterfly;
        }

        protected override void turnLeft() 
        {
            if (currentIndex != 0 && butterfly.Position.Y > EarthLevel) //проверка на уровень земли
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
            if (currentIndex != 7 && butterfly.Position.Y > EarthLevel) //проверка на уровень земли
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

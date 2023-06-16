using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services.Controller
{
    public class WormController: BackgroundCharacterController
    {
        public Worm worm { get; protected set; }

        public WormController(Worm worm)
        {
            this.worm = worm;
        }

        protected override void turnLeft()
        {
            if (currentIndex != 0) //проверка на уровень земли
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
            if (currentIndex != 7) //проверка на уровень земли
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

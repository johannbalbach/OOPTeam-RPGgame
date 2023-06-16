using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;
using OOPTeam2.RPG_Game.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.Services.Controller
{
    public class ButterflyController: BackgroundCharacterController
    {
        public Butterfly butterfly { get; protected set; }
        
        public ButterflyController(Butterfly butterfly)
        {
            this.butterfly = butterfly;
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

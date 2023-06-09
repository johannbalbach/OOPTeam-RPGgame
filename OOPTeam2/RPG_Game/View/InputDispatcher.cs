using OOPTeam2.RPG_Game.Services;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.View
{
    internal class InputDispatcher
    {
        private Player player;
        public InputDispatcher(Player player)
        {
            this.player = player;
        }

        public void DispathcInput()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                player.MoveRight();
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                player.MoveLeft();
            }
        }
    }
}

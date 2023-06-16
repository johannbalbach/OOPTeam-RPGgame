using OOPTeam2.RPG_Game.Services;
using OOPTeam2.RPG_Game.Services.Map;
using SFML.System;
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
            if (Keyboard.IsKeyPressed(Keyboard.Key.D) || Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                player.MoveRight();
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.A) || Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                player.MoveLeft();
            }
        }
    }
}

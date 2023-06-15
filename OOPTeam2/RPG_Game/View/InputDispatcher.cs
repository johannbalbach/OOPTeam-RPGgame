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
        private Map map;
        private Drawer drawer;
        public InputDispatcher(Map map, Drawer drawer)
        {
            this.map = map;
            this.drawer = drawer;
        }

        public void DispathcInput()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.D) || Keyboard.IsKeyPressed(Keyboard.Key.Right))
            {
                map.player.MoveRight();
            }
            else if (Keyboard.IsKeyPressed(Keyboard.Key.A) || Keyboard.IsKeyPressed(Keyboard.Key.Left))
            {
                map.player.MoveLeft();
            }
        }
    }
}

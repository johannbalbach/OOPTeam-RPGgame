using OOPTeam2.RPG_Game.Services;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace OOPTeam2.RPG_Game.View
{
    internal class Drawer
    {
        private PictureProvider pictureProvider = new PictureProvider();
        private RenderWindow window;
        private Map map;

        public Drawer(Map map) 
        { 
            this.map = map;
        } 

        public void SetRenderWindow(ref RenderWindow window)
        {
            this.window = window;
        }

        public void Draw()
        {
            foreach (var character in map.alive)
            {

            }
        }
    }
}

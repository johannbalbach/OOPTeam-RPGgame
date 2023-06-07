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

        public Drawer() { } 

        public void SetRenderWindow(ref RenderWindow window)
        {
            this.window = window;
        }

        public void Draw()
        {
            var s = pictureProvider.getSprite("HumanCharacter");
            window.Draw(s);
        }
    }
}

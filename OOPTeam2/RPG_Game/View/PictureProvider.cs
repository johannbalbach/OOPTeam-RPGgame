using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.View
{
    internal class PictureProvider
    {
        public Sprite humanSprite { get; }

        public PictureProvider()
        {
            humanSprite = new Sprite(new Texture("Assets/humanTexture.png"));
        }
    }
}

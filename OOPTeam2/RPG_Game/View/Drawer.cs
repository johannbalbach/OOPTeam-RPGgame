using OOPTeam2.RPG_Game.Services;
using SFML.Graphics;
using SFML.System;
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

        public void SetRenderWindow(RenderWindow window)
        {
            this.window = window;
        }

        public void Draw()
        {
            Sprite playerCharactersprite = pictureProvider.getSprite(map.player.managedCharacter.drawID);
            playerCharactersprite.Position = new Vector2f(map.player.managedCharacter.position.X, map.player.managedCharacter.position.Y);
            window.Draw(playerCharactersprite);

            foreach (GameCharacter character in map.aliveObjects.Enemies)
            {
                Sprite sprite = pictureProvider.getSprite(character.drawID);
                sprite.Position = new Vector2f(character.position.X, character.position.Y);
                window.Draw(sprite);
            }
        }
    }
}

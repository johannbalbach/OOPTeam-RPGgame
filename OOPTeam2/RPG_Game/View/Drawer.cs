using OOPTeam2.RPG_Game.Services;
using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using OOPTeam2.RPG_Game.Models.Characters;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters;

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

        private void updateViewPos()
        {
            Vector2f playerPos = new Vector2f(map.player.managedCharacter.Position.X, map.player.managedCharacter.Position.Y);
            Vector2f viewSize = window.GetView().Size;
            window.SetView(new SFML.Graphics.View(playerPos, viewSize));
        }

        public void Draw()
        {

            updateViewPos();

            Sprite playerCharacterSprite = pictureProvider.getSprite(map.player.managedCharacter.SkinId);
            playerCharacterSprite.Position = new Vector2f(map.player.managedCharacter.Position.X, map.player.managedCharacter.Position.Y);
            window.Draw(playerCharacterSprite);

            foreach (GameCharacter character in map.aliveObjects.Enemies)
            {
                Sprite sprite = pictureProvider.getSprite(character.SkinId);
                sprite.Position = new Vector2f(character.Position.X, character.Position.Y);
                window.Draw(sprite);
            }

            Sprite avatarSprite = pictureProvider.getSprite(map.avatarController.avatar.SkinId);
            avatarSprite.Position = new Vector2f(map.avatarController.avatar.Position.X, map.avatarController.avatar.Position.Y);
            window.Draw(avatarSprite);
        }
    }
}

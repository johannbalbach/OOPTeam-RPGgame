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
using OOPTeam2.RPG_Game.Services.Map;

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
            Vector2f playerPos = new Vector2f(map.player.managedCharacter.position.x, map.player.managedCharacter.position.y);
            Vector2f viewSize = window.GetView().Size;
            window.SetView(new SFML.Graphics.View(playerPos, viewSize));
        }

        private Sprite coordsToSystem(Sprite sprite)
        {
            float deltaX = -sprite.Texture.Size.X / 2;
            float deltaY = -sprite.Texture.Size.Y;
            sprite.Position = new Vector2f(sprite.Position.X + deltaX, sprite.Position.Y + deltaY);
            return sprite;
        }

        public void Draw()
        {
            updateViewPos();

            Sprite playerCharacterSprite = pictureProvider.getSprite(map.player.managedCharacter.skinId);
            playerCharacterSprite.Position = new Vector2f(map.player.managedCharacter.position.x, map.player.managedCharacter.position.y);
            playerCharacterSprite = coordsToSystem(playerCharacterSprite);
            window.Draw(playerCharacterSprite);

            foreach (GameCharacter character in map.aliveObjects.Enemies)
            {
                Sprite sprite = pictureProvider.getSprite(character.skinId);
                sprite.Position = new Vector2f(character.position.x, character.position.y);
                sprite = coordsToSystem(sprite);
                window.Draw(sprite);
            }

            foreach (var tile in map.staticObjects.stones)
            {
                Sprite sprite = pictureProvider.getSprite(tile.drawID);
                sprite.Position = new Vector2f(tile.position.x, tile.position.y);
                window.Draw(sprite);
            }

            Sprite avatarSprite = pictureProvider.getSprite(map.avatarController.avatar.skinId);
            avatarSprite.Position = new Vector2f(map.avatarController.avatar.position.x, map.avatarController.avatar.position.y);
            avatarSprite = coordsToSystem(avatarSprite);  
            window.Draw(avatarSprite);
        }
    }
}

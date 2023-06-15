﻿using OOPTeam2.RPG_Game.Services;
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

        private void coordsToSystem(Sprite sprite)
        {
            float deltaX = -sprite.Texture.Size.X / 2;
            float deltaY = -sprite.Texture.Size.Y;
            sprite.Position = new Vector2f(sprite.Position.X + deltaX, sprite.Position.Y + deltaY);
        }

        private void applyDirectionToSprite(Sprite characterSprite, Sprite weaponSprite, Direction direction)
        {
            if (direction == Direction.Right)
            {
                characterSprite.Scale = new Vector2f(-1, 1);
                characterSprite.Position = new Vector2f(characterSprite.Position.X + characterSprite.Texture.Size.X, characterSprite.Position.Y);
            }
            if(direction == Direction.Left)
            {
                weaponSprite.Scale = new Vector2f(-1, 1);
            }
        }

        private void configureCharacterSprite(Sprite characterSprite, Sprite weaponSprite, GameCharacter character)
        {
            characterSprite.Position = new Vector2f(character.position.x, character.position.y);
            weaponSprite.Position = new Vector2f(character.position.x,
                character.position.y - weaponSprite.Texture.Size.Y - characterSprite.Texture.Size.Y / 2 + 10);

            coordsToSystem(characterSprite);
            applyDirectionToSprite(characterSprite, weaponSprite, character.moveDirection); 
        }

        public void Draw()
        {
            updateViewPos();

            foreach (var tile in map.staticObjects.stones)
            {
                Sprite sprite = pictureProvider.getSprite(tile.drawID);
                sprite.Position = new Vector2f(tile.position.x, tile.position.y);
                window.Draw(sprite);
            }

            Sprite playerCharacterSprite = new Sprite( pictureProvider.getSprite(map.player.managedCharacter.skinId));
            Sprite playerWeaponSprite = new Sprite(pictureProvider.getSprite("KatanaSword"));
            configureCharacterSprite(playerCharacterSprite, playerWeaponSprite, map.player.managedCharacter);
            window.Draw(playerWeaponSprite);
            window.Draw(playerCharacterSprite);


            foreach (GameCharacter character in map.aliveObjects.Enemies)
            {
                Sprite characterSprite = new Sprite( pictureProvider.getSprite(character.skinId));
                Sprite weaponSprite = new Sprite(pictureProvider.getSprite("AlienWand"));
                configureCharacterSprite(characterSprite, weaponSprite, character);
                window.Draw(weaponSprite);
                window.Draw(characterSprite);
            }

            Sprite avatarSprite = pictureProvider.getSprite(map.avatarController.avatar.skinId);
            avatarSprite.Position = new Vector2f(map.avatarController.avatar.position.x, map.avatarController.avatar.position.y);
            coordsToSystem(avatarSprite);  
            window.Draw(avatarSprite);
        }
    }
}

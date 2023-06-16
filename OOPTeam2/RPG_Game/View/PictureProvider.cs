using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeam2.RPG_Game.View
{
    internal class PictureProvider
    {

        private Dictionary<String, Sprite> sprites = new Dictionary<String, Sprite>();
        public PictureProvider()
        {
            sprites.Add("HumanCharacter", new Sprite(new Texture("Assets/HumanCharacterTexture.png")));
            sprites.Add("AlienCharacter", new Sprite(new Texture("Assets/AlienCharacterTexture.png")));
            sprites.Add("ElfCharacter", new Sprite(new Texture("Assets/ElvesCharacterTexture.png")));
            sprites.Add("GnomeCharacter", new Sprite(new Texture("Assets/GnomeCharacterTexture.png")));
            sprites.Add("OrkCharacter", new Sprite(new Texture("Assets/OrksCharacterTexture.png")));
            sprites.Add("WandCharacter", new Sprite(new Texture("Assets/WandCharacterTexture.png")));

            sprites.Add("Avatar", new Sprite(new Texture("Assets/AvatarTexture.png")));

            sprites.Add("Stone", new Sprite(new Texture("Assets/TileDirtTexture.png")));

            sprites.Add("KatanaSword", new Sprite(new Texture("Assets/KatanaSwordTexture.png")));
            sprites.Add("LevithanSword", new Sprite(new Texture("Assets/LevithanSwordTexture.png")));
            sprites.Add("MaceSword", new Sprite(new Texture("Assets/MaceSwordTexture.png")));
            sprites.Add("AlienWand", new Sprite(new Texture("Assets/AlienWandTexture.png")));
            sprites.Add("ElvenWand", new Sprite(new Texture("Assets/ElvenWandTexture.png")));
            sprites.Add("WizardWand", new Sprite(new Texture("Assets/WizardWandTexture.png")));

            sprites.Add("EpicPotion", new Sprite(new Texture("Assets/EpicPotionTexture.png")));
            sprites.Add("HealingPotion", new Sprite(new Texture("Assets/HealingPotionTexture.png")));
            sprites.Add("ToxicPotion", new Sprite(new Texture("Assets/ToxicPotionTexture.png")));
        }

        public Sprite getSprite(String key)
        {
            if (sprites.ContainsKey(key))
            {
                return sprites[key];
            }
            else
            {
                throw new Exception($"Sprite with name {key} not exist");
            }
        }
    }
}

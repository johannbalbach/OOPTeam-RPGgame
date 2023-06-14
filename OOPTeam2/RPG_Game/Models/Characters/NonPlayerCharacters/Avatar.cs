using System;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using OOPTeam2.RPG_Game.Models.Potions;
using OOPTeam2.RPG_Game.Models.Swords;
using OOPTeam2.RPG_Game.Models.Wands;
using OOPTeam2.RPG_Game.Services;

namespace OOPTeam2.RPG_Game.Models.Characters.NonPlayerCharacters {
    public class Avatar: NonPlayerCharacter {
        private SingletonRand random { set; get; }

        public Avatar() {
            lifePoint = Int32.MaxValue;
            random = SingletonRand.GetInstance();
            text = new CharacterReply(TextEnum.AvatarText);
        }
        
        public override string Talk() {
            return text.GetText();
        }

        public override bool Hit(Sword sword, CharacterRace characterRace) {
            // с вероятностью 50% удар в аватара будет отражён тайной силой 
            int chanceToHit = random.Next(0, 1);
            if (chanceToHit == 1) {
                lifePoint -= sword.GetDamage(characterRace);
                return true;
            }
            return false;
        }

        public override bool Hit(Potion potion) {
            // Аватар не может быть отравлен
            return false;
        }

        public override bool Hit(Wand wand, CharacterRace characterRace) {
            lifePoint -= wand.GetHarm(characterRace);
            return true;
        }
        
        public void RestoreHealth() {
            lifePoint = Int32.MaxValue;
        }
    }
}

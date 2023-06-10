using System;
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
        }

        public override string Talk() {
            return "I am the Avatar, the master of the skies and the wielder of immense magic!";
        }

        public override void Hit(Sword sword) {
            int chanceToHit = random.Next(0, 1);
            if (chanceToHit == 1) {
                lifePoint -= sword.GetDamage();
            }
        }

        public override void Hit(Potion potion) {
            // Аватар не может быть отравлен
        }

        public override void Hit(Wand wand) {
            lifePoint -= wand.GetHarm();
        }
        
        public void RestoreHealth() {
            lifePoint = Int32.MaxValue;
        }
    }
}

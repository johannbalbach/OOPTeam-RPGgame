using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class EpicPotion: Potion {
        public int bonusPercent { set; get; }
        
        public EpicPotion(int volume, string description, int bonusPercent, int damage) {
            this.volume = volume;
            this.description = description;
            this.bonusPercent = bonusPercent;
            this.damage = damage;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.Human,
                CharacterRace.Alien,
                CharacterRace.Elf,
                CharacterRace.Gnome
            };
        }

        public EpicPotion() : this (EpicPotionVolume, EpicPotionDescription, 
            EpicPotionBonusPercent, EpicPotionDamage) {

        }

        public override int ToDamage(CharacterRace characterRace) {
            if (possibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                ReduceVolume();
                return damage * bonusPercent;
            }
            return 0;
        }

        public override bool IsEnoughVolume() {
            return volume >= EpicPotionVolume;
        }

        public override void Drop() {
            volume = 0;
        }

        public override void ReduceVolume() {
            volume -= EpicPotionVolume;
        }
        
        public override void Improve() {
            bonusPercent += EpicPotionImproving;
        }
    }
}

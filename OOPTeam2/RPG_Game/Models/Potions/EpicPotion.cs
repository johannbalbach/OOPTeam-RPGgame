using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitialWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Potions {
    public class EpicPotion: Potion {
        public int BonusPercent { set; get; }
        
        public EpicPotion(int volume, int bonusPercent, int damage) {
            Volume = volume;
            BonusPercent = bonusPercent;
            Damage = damage;
            SkinId = EpicPotionSkinId;
            PossibleOwners = new List<CharacterRace> { 
                CharacterRace.Human,
                CharacterRace.Alien,
                CharacterRace.Elf,
                CharacterRace.Gnome
            };
        }

        public EpicPotion() : this (EpicPotionVolume, EpicPotionBonusPercent, EpicPotionDamage) {

        }

        public override int ToDamage(CharacterRace characterRace) {
            if (PossibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                ReduceVolume();
                return Damage * BonusPercent;
            }
            return 0;
        }

        public override bool IsEnoughVolume() {
            return Volume >= EpicPotionVolume;
        }

        public override void Drop() {
            Volume = 0;
        }

        public override void ReduceVolume() {
            Volume -= EpicPotionVolume;
        }
        
        public override void Improve() {
            BonusPercent += EpicPotionImproving;
        }
    }
}
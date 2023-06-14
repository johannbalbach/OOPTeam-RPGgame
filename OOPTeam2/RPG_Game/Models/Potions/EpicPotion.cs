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
                CharacterRace.HumanCharacter,
                CharacterRace.AlienCharacter,
                CharacterRace.ElvesCharacter,
                CharacterRace.GnomeCharacter
            };
            typePotion = TypePotion.EpicPotion;
        }
        
        public EpicPotion() {
            volume = EPIC_POTION_VOLUME;
            description = EPIC_POTION_DESCRIPTION;
            bonusPercent = EPIC_POTION_BONUS_PERCENT;
            damage = EPIC_POTION_DAMAGE;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.HumanCharacter,
                CharacterRace.AlienCharacter,
                CharacterRace.ElvesCharacter,
                CharacterRace.GnomeCharacter
            };
            typePotion = TypePotion.EpicPotion;
        }

        public override int GetHurt(CharacterRace characterRace) {
            if (possibleOwners.Contains(characterRace) && IsEnoughVolume()) {
                Reduce();
                return damage * bonusPercent;
            }
            return 0;
        }

        public override bool IsEnoughVolume() {
            return volume >= EPIC_POTION_VOLUME;
        }

        public override void Reduce() {
            volume -= EPIC_POTION_VOLUME;
        }
        
        public override void Increase() {
            bonusPercent += EPIC_POTION_IMPROVING;
        }
    }
}

using System.Collections.Generic;
using OOPTeam2.RPG_Game.Models.Characters.GameCharacters;
using static OOPTeam2.RPG_Game.Models.InitWeaponConstants;

namespace OOPTeam2.RPG_Game.Models.Swords {
    public class LevithanSword: Sword {
        public LevithanSword(double weight, double agility, double quality, int attack, bool isAvailable) {
            this.weight = weight;
            this.agility = agility;
            this.quality = quality;
            this.attack = attack;
            this.isAvailable = isAvailable;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.GnomeCharacter,
                CharacterRace.HumanCharacter
            };
        }
        
        public LevithanSword() {
            weight = LEVITHAN_SWORD_WEIGHT;
            agility = LEVITHAN_SWORD_AGILITY;
            quality = LEVITHAN_SWORD_QUALITY;
            attack = LEVITHAN_SWORD_ATTACK;
            possibleOwners = new List<CharacterRace> { 
                CharacterRace.ElvesCharacter,
                CharacterRace.HumanCharacter
            };
        }
        
        public override int GetDamage(CharacterRace characterRace) {
            if (isAvailable && possibleOwners.Contains(characterRace)) {
                return CalculateDamage();
            }
            return 0;
        }
        
        public override int CalculateDamage() {
            if (weight >= LEVITHAN_SWORD_BONUS_WEIGHT) {
                return attack * LEVITHAN_SWORD_BONUS_COEFFICIENT;
            }
            return attack;
        }

        public override void Boost() {
            quality += LEVITHAN_SWORD_BONUS_COEFFICIENT;
            weight -= LEVITHAN_SWORD_BONUS_WEIGHT;
        }

        public override void Drop() {
            if (isAvailable) {
                isAvailable = false;
            }
        }
    }
}